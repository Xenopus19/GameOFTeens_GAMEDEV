using UnityEngine;

public class TransportMovement : MonoBehaviour
{
    [SerializeField] private float m_MovementSpeed = 0.1f;
    [SerializeField] private Vector2 m_BordersX;

    [SerializeField] private Animation CameraFinishAnimation;
    [SerializeField] private Animation JiggleAnimation;

    private bool ControlsFreezed;

    private void Start()
    {
        ControlsFreezed = false;
        Level.OnLevelFinished += FreezeControlsMoveCamera;    
    }


    void Update()
    {
        if (ControlsFreezed) return;

        Drive();
    }

    private void Drive()
    {
        Vector3 direction = CalculateDirection();
        if ((direction.x >= 0 && transform.position.x <= m_BordersX.x) ||
            (direction.x <= 0 && transform.position.x >= m_BordersX.y))
            return;

        transform.Translate(direction * m_MovementSpeed * Time.deltaTime);
    }

    private Vector3 CalculateDirection()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        
        return new Vector3(mousePos3D.x - transform.position.x, 0, 0);
    }

    private void FreezeControlsMoveCamera()
    {
        ControlsFreezed = true;
        CameraFinishAnimation.Play();
        JiggleAnimation.Stop();
    }

    private void OnDestroy() => Level.OnLevelFinished -= FreezeControlsMoveCamera;
}
