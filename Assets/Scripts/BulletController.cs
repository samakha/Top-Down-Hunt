using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 15f;
    Rigidbody2D rb;
    Transform firePOint;  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        firePOint = GameObject.Find("firePoint").transform;
        rb.AddForce(firePOint.up, ForceMode2D.Impulse); 
    }
}
