using UnityEngine;

public class TransportMovement : MonoBehaviour
{
    [SerializeField] private float m_MovementSpeed = 0.1f;
    [SerializeField] private Vector2 m_BordersX;

    [SerializeField] private Animation CameraFinishAnimation;
    [SerializeField] private Animation JiggleAnimation;

    private Vector3 Direction;

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
        if ((Direction.x >= 0 && transform.position.x <= m_BordersX.x) ||
            (Direction.x <= 0 && transform.position.x >= m_BordersX.y))
            return;

        transform.Translate(Direction * m_MovementSpeed * Time.deltaTime);
    }

    public void SetDirection(Vector3 direction)
    {
        Direction = direction;
    }

    private void FreezeControlsMoveCamera()
    {
        ControlsFreezed = true;
        CameraFinishAnimation.Play();
        JiggleAnimation.Stop();
    }

    private void OnDestroy() => Level.OnLevelFinished -= FreezeControlsMoveCamera;
}
