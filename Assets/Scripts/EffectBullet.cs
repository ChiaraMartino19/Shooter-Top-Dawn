using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBullet : MonoBehaviour
{
    [SerializeField] private GameObject hitEffect;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.4f);
        Destroy(gameObject);
    }
}
