using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float Damage;
    [SerializeField] private float SeconsToShoot;

    private Shooting shooting;

    void Start()
    {
        shooting = GetComponent<Shooting>();
        StartCoroutine(Shoot());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Health>().RemoveHP(Damage);
        }
    }

    private IEnumerator Shoot()
    {
        yield return new WaitForSeconds(SeconsToShoot);
        shooting.Shoot();
        StartCoroutine(Shoot());
    }
}
