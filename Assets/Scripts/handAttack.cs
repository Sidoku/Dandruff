using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handAttack : MonoBehaviour
{
    [SerializeField] private bool handAttackCheck = false;
    [SerializeField] private Animator anim;
    [SerializeField] private Vector2 playerPosition;

    private GameObject playerObj = null;

    // Start is called before the first frame update
    void Start()
    {
        if (playerObj == null)
        {
            playerObj = GameObject.FindGameObjectWithTag("Player");
        }
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
        // Go to player position and scratch
        playerPosition = playerObj.transform.position;
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
