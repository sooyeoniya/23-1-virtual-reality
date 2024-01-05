using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectHeart : MonoBehaviour
{
    public GameObject heartButtonPrefab;
    public Transform inventoryContent;
    public Text infoText;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);

        GameObject heartButton = Instantiate(heartButtonPrefab, inventoryContent);
        heartButton.transform.SetAsLastSibling();

        ButtonClickHandler buttonClickHandler = heartButton.GetComponent<ButtonClickHandler>();
        if (buttonClickHandler != null)
        {
            buttonClickHandler.Initialize(heartButton.GetComponent<Button>(), infoText);
        }
    }
}