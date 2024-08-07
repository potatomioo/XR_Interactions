using UnityEngine;

public class EnDes : MonoBehaviour
{
    public GameObject targetObject;

    public void ToggleVisibility()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(!targetObject.activeSelf);
        }
    }
}
