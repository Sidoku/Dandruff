using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RemoveHair : MonoBehaviour
{

    private GameObject[] hairObj = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hair"))
        {
            Debug.Log(other.gameObject.name);
            hairObj.Append(other.gameObject);
        }
        else if (other.gameObject.name == "HandAnimations" && hairObj != null && gameObject.GetComponent<Renderer>().material.GetColor("_BaseColor").a > 0.9f)
        {
            for (int i = 0; i < hairObj.Length; ++i)
            {
                Destroy(hairObj[i]);
            }
        }
    }
}