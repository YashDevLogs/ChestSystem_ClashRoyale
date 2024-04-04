using UnityEngine;
using UnityEngine.UI;

public class ClosePanel : MonoBehaviour
{

    private void Start()
    {
        // Get the Button component attached to this GameObject
        Button cancelButton = GetComponent<Button>();

        // Add a listener to the button click event
        cancelButton.onClick.AddListener(CloseParent);
    }

    private void CloseParent()
    {
        // Deactivate the parent GameObject of the cancel button
        gameObject.transform.parent.gameObject.SetActive(false);
    }
}
