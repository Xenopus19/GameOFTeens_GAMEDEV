using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    private Vector3 direction;

    private void Start()
    {
        direction = new Vector3(0, 0, 1);
    }

    void Update()
    {
        transform.Translate(direction * m_Speed * Time.deltaTime);
    }
}
