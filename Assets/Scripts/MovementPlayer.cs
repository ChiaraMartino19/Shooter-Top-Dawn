using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float velocity = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 mousePos;
    public Camera cam;



    void Update()
    {


        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); 

      
      
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * velocity * Time.fixedDeltaTime);
        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
