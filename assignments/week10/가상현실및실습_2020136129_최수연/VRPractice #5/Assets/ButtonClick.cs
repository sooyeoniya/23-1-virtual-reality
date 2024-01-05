using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public GameObject Button;
    public Image image;

    void Start()
    {
        Button = GameObject.Find("Button");
    }

    public void ButtonDisappear()
    {
        Button.SetActive(false);
        Debug.Log("버튼 사라짐");
    }

    public void ScreenFaded()
    {
        Debug.Log("화면 점점 어두워짐");
        StartCoroutine(FadePanel());
    }

    IEnumerator FadePanel()
    {
        float fadeCount = 0;

        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            image.color = new Color(0, 0, 0, fadeCount);
        }
    }
}
