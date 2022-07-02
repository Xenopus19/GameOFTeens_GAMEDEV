using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public GameObject Shooter;

    [SerializeField] private int Damage;
    [SerializeField] private GameObject Effects;

    private void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Shooter.GetComponent<Enemy>() == collision.gameObject.GetComponent<Enemy>())
            return;

        Health health = collision.gameObject.GetComponent<Health>();

        if (health == null) return;

        health.RemoveHP(Damage);

        if (collision.gameObject.GetComponent<Bullet>() != null)
            Destroy(collision.gameObject);

        DestroyBullet();
    }

    private void DestroyBullet()
    {
        Instantiate(Effects, transform.position, Quaternion.identity, transform.parent);
        Destroy(gameObject);
    }
}
