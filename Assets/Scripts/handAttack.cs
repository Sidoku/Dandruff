using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class handAttack : MonoBehaviour
{
    [SerializeField] private bool handAttackCheck = false;
    [SerializeField] private Animator anim;
    [SerializeField] private Vector2 playerPosition;
    public float speed = 1.0F;
    public Transform startMarker;
    private float startTime;
    private float journeyLength;
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
            HandPosUpdate();
        }


    }
    void AttackPlayer()
    {
        // Go to player position and scratch
        
        playerPosition = playerObj.transform.position;
        startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(startMarker.position, playerPosition);

    }
    IEnumerator RandomAttackTimer()
    {
        while (true)
        {
            AttackPlayer();
            yield return new WaitForSeconds(Random.Range(1, 5));
        }
    }

    private void HandPosUpdate ()
    {
        

        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(startMarker.position, playerPosition, fractionOfJourney);

    }
}
