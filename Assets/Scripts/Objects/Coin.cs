using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int amountOfMoney;

    [SerializeField] private GameObject Effects;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Animation destroyAnim;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Money.IncreaseMoney(amountOfMoney);
            StartCoroutine(nameof(DestroyBox));
        }
    }

    private IEnumerator DestroyBox()
    {
        Instantiate(Effects, transform.position, Quaternion.identity, transform.parent);
        audioSource.Play();
        destroyAnim.Play();
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
