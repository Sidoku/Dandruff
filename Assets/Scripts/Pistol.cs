using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{

    public Animator animator;
    public int pistolID;
    public bool isAttacking;
    public AudioSource playerAudio;
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
            isAttacking = true;
        }else
        {
            animator.SetBool(pistolID, false);
            isAttacking = false;
        }

        if(isAttacking)
        {
            StartCoroutine(PlayAudio());
        }
            
    }

    IEnumerator PlayAudio()
    {
        yield return new WaitForSeconds(1);
        playerAudio.Play();
    }
}
