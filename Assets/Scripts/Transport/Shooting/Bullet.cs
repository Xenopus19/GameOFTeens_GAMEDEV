using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    [SerializeField] private int Damage;
    private void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();

        if (health == null) return;

        health.RemoveHP(Damage);
    }
}
