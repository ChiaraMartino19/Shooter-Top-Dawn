using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    GameObject target;
    [SerializeField] private float speed;
    Rigidbody2D rbBullet;
    void Start()
    {
        rbBullet = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDirection = (target.transform.position - transform.position).normalized * speed;
        rbBullet.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(this.gameObject, 2f);
    }

}
