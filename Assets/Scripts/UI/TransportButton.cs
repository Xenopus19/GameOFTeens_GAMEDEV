using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TransportButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Vector3 Direction;

    private Vector3 EmptyVector;
    private TransportMovement movement;

    void Start()
    {
        movement = GameObject.FindGameObjectWithTag("Player")
            .GetComponent<TransportMovement>();

        EmptyVector = new Vector3(0, 0, 0);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        movement.SetDirection(Direction);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        movement.SetDirection(EmptyVector);
    }
}
