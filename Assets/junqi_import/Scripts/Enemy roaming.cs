using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyroaming : MonoBehaviour
{
    public float speed = 5; 
    public Transform[] patrolpoints;
    private int patrolindex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, patrolpoints[patrolindex].position, speed * Time.deltaTime);

        if (transform.position == patrolpoints[patrolindex].position)
        { 
            patrolindex++;

            if (patrolindex < patrolpoints.Length)
            {

            }

        }

    }
}
