using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    private MovementPlayer movementPlayer;
    public Transform player;



    private void Start()
    {
        movementPlayer = player.GetComponent<MovementPlayer>();
    }
    void Update()
    {
     
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }

       


    }


    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.transform.up * bulletSpeed, ForceMode2D.Impulse);
        Destroy(bullet, 1f);
    }
}
