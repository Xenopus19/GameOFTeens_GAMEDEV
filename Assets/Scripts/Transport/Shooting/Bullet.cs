using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public GameObject Shooter;

    [SerializeField] private int Damage;
    private void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Shooter.GetComponent<Enemy>() == Shooter.GetComponent<Enemy>())
            return;

        Health health = collision.gameObject.GetComponent<Health>();

        if (health == null) return;

        health.RemoveHP(Damage);
    }
}
