using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectBullet : MonoBehaviour
{
    public GameObject bulletButtonPrefab;
    public Transform inventoryContent;
    public Text infoText;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);

        GameObject bulletButton = Instantiate(bulletButtonPrefab, inventoryContent);
        bulletButton.transform.SetAsLastSibling();

        ButtonClickHandler buttonClickHandler = bulletButton.GetComponent<ButtonClickHandler>();
        if (buttonClickHandler != null)
        {
            buttonClickHandler.Initialize(bulletButton.GetComponent<Button>(), infoText);
        }
    }
}