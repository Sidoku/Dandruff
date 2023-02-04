using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{

    public Animator animator;
    int pistolID;
    // Start is called before the first frame update
    void Start()
    {
        pistolID = Animator.StringToHash("pistol");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetBool(pistolID, true);
        }else
        {
            animator.SetBool(pistolID, false);
        }
            
    }
}
