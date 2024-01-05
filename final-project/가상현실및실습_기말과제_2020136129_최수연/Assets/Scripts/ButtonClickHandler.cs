using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public Text infoText;
    public static Button lastClickedButton;

    public void Initialize(Button button, Text text)
    {
        lastClickedButton = button;
        infoText = text;
    }

    public void OnButtonClick(Button button)
    {
        lastClickedButton = button;
        Debug.Log("1");
        if (lastClickedButton != null)
        {
            Debug.Log("2");
            if (lastClickedButton.CompareTag("BulletBtn"))
            {
                infoText.text = "이 아이템은 총알입니다.";
                Debug.Log(infoText.text);
                Debug.Log("BulletBtn");
            }
            if (lastClickedButton.CompareTag("HeartBtn"))
            {
                infoText.text = "이 아이템은 체력 회복입니다.";
                Debug.Log(infoText.text);
                Debug.Log("HeartBtn");
            }
            if (lastClickedButton.CompareTag("HourBtn"))
            {
                infoText.text = "이 아이템은 시간 연장입니다.";
                Debug.Log(infoText.text);
                Debug.Log(infoText);
                Debug.Log("HourBtn");
            }
            Canvas.ForceUpdateCanvases();
        }
    }

    public void OnUseItemBottonClick()
    {
        Debug.Log(lastClickedButton);
        if (lastClickedButton != null)
        {
            if (lastClickedButton.CompareTag("BulletBtn"))
            {
                GameObject player = GameObject.FindWithTag("Player");
                if (player != null)
                {
                    Fire fire = player.GetComponent<Fire>();
                    if (fire != null)
                    {
                        fire.IncreaseBulletCount();
                    }
                }
                Destroy(lastClickedButton.gameObject);
            }
            else if (lastClickedButton.CompareTag("HeartBtn"))
            {
                GameObject player = GameObject.FindWithTag("Player");
                if (player != null)
                {
                    PlayerController playerController = player.GetComponent<PlayerController>();
                    Debug.Log(playerController);
                    if (playerController != null)
                    {
                        playerController.IncreaseHeartCount();
                    }
                }
                Destroy(lastClickedButton.gameObject);
            }
            else if (lastClickedButton.CompareTag("HourBtn"))
            {
                GameObject player = GameObject.FindWithTag("Player");
                if (player != null)
                {
                    PlayerController playerController = player.GetComponent<PlayerController>();
                    Debug.Log(playerController);
                    if (playerController != null)
                    {
                        playerController.IncreaseGameTime();
                    }
                }
                Destroy(lastClickedButton.gameObject);
            }
        }
    }
}