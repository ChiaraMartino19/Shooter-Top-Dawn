using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
   
    [SerializeField] private int damage;
  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<MovementPlayer>().TakeDamage(damage);
            Destroy(gameObject);
        }

    }
}
