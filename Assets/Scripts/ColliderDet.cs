using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDet : MonoBehaviour
{
    public GameObject objectToDetect;
    public GameObject thirdObject;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == objectToDetect)
        {
            EnableThirdObject();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == objectToDetect)
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
