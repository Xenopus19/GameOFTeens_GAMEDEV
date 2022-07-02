using UnityEngine;
using System.Collections;


public class BoxScript : MonoBehaviour
{
    [SerializeField] private int scoreAddAmount;
    [SerializeField] private GameObject Effects;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Animation destroyAnim;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Score.Instance.AddScore(scoreAddAmount);
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
