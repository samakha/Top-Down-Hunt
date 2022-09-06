using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    Transform playerPos; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = GameObject.Find("Player").transform;
        transform.position = new Vector3(playerPos.position.x, playerPos.position.y, transform.position.z -10f);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -6, 6), Mathf.Clamp(transform.position.y, -6, 6)); 
    }
}
