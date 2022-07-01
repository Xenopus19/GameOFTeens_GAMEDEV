using UnityEngine;

public class TransposrtMovement : MonoBehaviour
{
    [SerializeField] private float m_MovementSpeed = 0.1f;

    void Update()
    {
        Drive();
    }

    private void Drive()
    {
        Vector3 direction = CalculateDirection();
        transform.Translate(direction * m_MovementSpeed * Time.deltaTime);
    }

    private Vector3 CalculateDirection()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        
        return new Vector3(mousePos3D.x - transform.position.x, 0, 0);
    }
}
