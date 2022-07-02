using System;
using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour, IDieable
{
    [SerializeField] private bool IsShooting = true;
    [SerializeField] private float Damage;
    [SerializeField] private float SeconsToShoot;
    [SerializeField] private GameObject Effects;

    private Shooting shooting;

    public static int EnemyReward = 50;

    void Start()
    {
        shooting = GetComponent<Shooting>();

        if(IsShooting)
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
        Debug.Log("Touched");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Health>().RemoveHP(Damage);
            Die();
        }
    }

    public void Die()
    {
        Instantiate(Effects, transform.position, Quaternion.identity, transform.parent);
        Destroy(gameObject);
    }
}
