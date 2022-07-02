using System;
using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float Damage;
    [SerializeField] private float SeconsToShoot;
    [SerializeField] private GameObject Effects;

    private Shooting shooting;

    public static int EnemyReward = 50;

    void Start()
    {
        shooting = GetComponent<Shooting>();
        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        yield return new WaitForSeconds(SeconsToShoot);
        shooting.Shoot();
        StartCoroutine(Shoot());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Health>().RemoveHP(Damage);
            DestroyEnemy();
        }
    }

    private void DestroyEnemy()
    {
        Instantiate(Effects, transform.position, Quaternion.identity, transform.parent);
        Destroy(gameObject);
    }
}
