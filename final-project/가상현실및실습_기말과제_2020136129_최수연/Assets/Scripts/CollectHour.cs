using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectHour : MonoBehaviour
{
    public GameObject hourButtonPrefab;
    public Transform inventoryContent;
    public Text infoText;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);

        GameObject hourButton = Instantiate(hourButtonPrefab, inventoryContent);
        hourButton.transform.SetAsLastSibling();

        ButtonClickHandler buttonClickHandler = hourButton.GetComponent<ButtonClickHandler>();
        if (buttonClickHandler != null)
        {
            buttonClickHandler.Initialize(hourButton.GetComponent<Button>(), infoText);
        }
    }
}