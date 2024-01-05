using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigid;
    public Transform playerTrans;
    public GameObject miniMap;
    public GameObject inventory;
    public GameObject description;
    public GameObject useButton;
    public GameObject fireCracker;

    public float walkSpeed = 9f;
    public float runSpeed = 13f;
    public float roSpeed = 120;
    private float currentSpeed;
    private float xRotate = 0.0f;

    private int maxHP = 3;
    public int currentHP;

    public Text GameOverText;
    private bool isGameOver = false;

    public Text FinishText;
    private bool isFinished = false;
    private bool isFinishedControl = true;

    public float gameTime = 200f;
    public Text TimerText;
    public Text TimeOverText;
    private bool isTimeOver = false;

    public AudioSource audioSource;
    public AudioClip runSound;
    public AudioClip walkSound;

    void Start()
    {
        currentHP = maxHP;
        GameOverText.gameObject.SetActive(false);
        FinishText.gameObject.SetActive(false);
        TimeOverText.gameObject.SetActive(false);
        UpdateTimerText();
        miniMap.SetActive(false);
        inventory.SetActive(false);
        description.SetActive(false);
        useButton.SetActive(false);
        fireCracker.SetActive(false);
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    void Update()
    {
        KeyControl();
        KeyRotation();
        GameOver();
        Timer();
    }

    void KeyControl()
    {
        if (isFinishedControl)
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                currentSpeed = runSpeed;
                if (!audioSource.isPlaying && runSound != null)
                {
                    audioSource.clip = runSound;
                    audioSource.Play();
                }
            }
            else
            {
                currentSpeed = walkSpeed;
                if (!audioSource.isPlaying && walkSound != null && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)))
                {
                    audioSource.clip = walkSound;
                    audioSource.Play();
                }
                else if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
                {
                    audioSource.Stop();
                }
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                miniMap.SetActive(!miniMap.activeSelf);
                inventory.SetActive(!inventory.activeSelf);
                description.SetActive(!description.activeSelf);
                useButton.SetActive(!useButton.activeSelf);
            }

            if (Input.GetKey(KeyCode.W))
            {
                playerRigid.velocity = transform.forward * currentSpeed;
            }

            if (Input.GetKey(KeyCode.S))
            {
                playerRigid.velocity = -transform.forward * currentSpeed;
            }

            if (Input.GetKey(KeyCode.A))
            {
                playerTrans.Rotate(0, -roSpeed * Time.deltaTime, 0);
            }

            if (Input.GetKey(KeyCode.D))
            {
                playerTrans.Rotate(0, roSpeed * Time.deltaTime, 0);
            }
        }
    }

    void KeyRotation()
    {
        float yRotation = Input.GetAxis("Mouse X") * 4f;
        float yRotate = transform.eulerAngles.y + yRotation;
        float xRotation = -Input.GetAxis("Mouse Y") * 4f;
        xRotate = Mathf.Clamp(xRotate + xRotation, -45, 80);
        transform.rotation = Quaternion.Euler(new Vector3(xRotate, yRotate, 0));
    }

    void GameOver()
    {
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }

        if (currentHP <= 0 && !isGameOver)
        {
            isGameOver = true;
            GameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monster"))
        {
            currentHP--;
        }
        if (other.CompareTag("Finish"))
        {
            OnFinish();
        }
    }

    public void IncreaseHeartCount()
    {
        currentHP++;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }
    }

    void OnFinish()
    {
        if (!isFinished)
        {
            isFinished = true;
            FinishText.gameObject.SetActive(true);
            isFinishedControl = false;
            fireCracker.SetActive(true);
        }
    }

    void Timer()
    {
        if (isFinishedControl)
        {
            gameTime -= Time.deltaTime;
            UpdateTimerText();

            if (gameTime <= 0 && !isTimeOver)
            {
                isTimeOver = true;
                gameTime = 0;
                UpdateTimerText();
                TimeOverText.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(gameTime / 60f);
        int seconds = Mathf.FloorToInt(gameTime % 60f);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        TimerText.text = timeString;
    }

    public void IncreaseGameTime()
    {
        gameTime += 10f;
        UpdateTimerText();
    }
}