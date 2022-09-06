using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] float chaseSpeed;
    Transform playerPos; 
    void Start()
    {
                playerPos = GameObject.Find("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if( Vector2.Distance(playerPos.position , transform.position) > 1f)
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, chaseSpeed * Time.deltaTime); 
    }
}
