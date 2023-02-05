using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handAttack : MonoBehaviour
{
    [SerializeField] private bool handAttackCheck = false;
    [SerializeField] private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RandomAttackTimer());

    }

    // Update is called once per frame
    void Update()
    {
        if(handAttackCheck == true){
            anim.SetTrigger("Scratch");
        }
    }
    void AttackPlayer()
    {
        
    }
    IEnumerator RandomAttackTimer()
    {
        while (true)
        {
            AttackPlayer();
            yield return new WaitForSeconds(Random.Range(1, 5));
        }
    }
}
