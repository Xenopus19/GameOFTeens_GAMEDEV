using UnityEngine;

public class BoxScript : MonoBehaviour
{
    [SerializeField] private int scoreAddAmount;
    [SerializeField] private GameObject Effects;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Score.Instance.AddScore(scoreAddAmount);
            DestroyBox();
        }
    }

    private void DestroyBox()
    {
        Instantiate(Effects, transform.position, Quaternion.identity, transform.parent);
        Destroy(gameObject);
    }
}
