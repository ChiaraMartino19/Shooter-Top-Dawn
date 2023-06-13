using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIenemy : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed;
    [SerializeField] private float distance;
    [SerializeField] private float shootingRange;
    [SerializeField] private GameObject bulletEnemy;
    [SerializeField] private GameObject bulletPoint;
    [SerializeField] private float fireRate = 1f;
    private float nextFireTime;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

  
    void Update()
    {
       float distancePlayer = Vector2.Distance(player.position, transform.position);
        
       


        if(distancePlayer < distance && distancePlayer>shootingRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
           
        }
        else if (distancePlayer <= shootingRange && nextFireTime < Time.time)
        {
            Instantiate(bulletEnemy, bulletPoint.transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
        }



    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, distance);
        Gizmos.DrawSphere(transform.position, shootingRange);

    }
}
