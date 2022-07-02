using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int Damage;

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Health>().RemoveHP(Damage);
        }
    }
}
