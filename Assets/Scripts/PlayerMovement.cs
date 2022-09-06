using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyJoystick; 
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    Vector2 moveInput;
    Vector2 mousePos; 
    Rigidbody2D rb;

    [SerializeField] private Joystick joyStick; 


    [SerializeField] Transform firePoint; 
    public Camera cam;

    [SerializeField] GameObject bulletPrefabs; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Movement();
        Rotation();
        
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -8f, 8f), Mathf.Clamp(transform.position.y, -8, 8)); 
    }
    void Movement( )
    {
        //moveInput.x = Input.GetAxisRaw("Horizontal");
        //moveInput.y = Input.GetAxisRaw("Vertical");

         moveInput.x = joyStick.Horizontal(); 
         moveInput.y = joyStick.Vertical(); 

        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.deltaTime); 
    }

    void Rotation( )
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = angle; 
    }
   public void Shooting()
    {
         
            GameObject bullet = Instantiate(bulletPrefabs, firePoint.position, firePoint.rotation);
            Destroy(bullet, 2f); 
       
    }
}
