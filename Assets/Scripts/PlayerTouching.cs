using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTouching : MonoBehaviour
{
    public GameObject PlayerVariant;
    private Material m_material;
   /* private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Color color = m_material.color;
            while ((color.a > 0) && PlayerVariant.GetComponent<ThirdPersonController>()._animator.GetComponent<Pistol>().isAttacking)
            {
                color.a -= 1f * Time.deltaTime;
            }
        }
    }*/
}
