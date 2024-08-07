using UnityEngine;

public class ButtonInteract : MonoBehaviour
{
    public GameObject thirdObject; // Assign this in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        // Check if the other collider is one of the XR controllers
        if (other.CompareTag("XRController"))
        {
            EnableThirdObject();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the other collider is one of the XR controllers
        if (other.CompareTag("XRController"))
        {
            DisableThirdObject();
        }
    }

    private void EnableThirdObject()
    {
        if (thirdObject != null)
        {
            thirdObject.SetActive(true);
        }
    }

    private void DisableThirdObject()
    {
        if (thirdObject != null)
        {
            thirdObject.SetActive(false);
        }
    }
}
