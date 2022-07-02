using UnityEngine;

public class DieCanvas : MonoBehaviour
{
    private PlayerDeath death;
    void Start()
    {
        death = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDeath>();
        death.OnDie += ActivateDieCanvas;
    }

    private void ActivateDieCanvas()
    {
        gameObject.SetActive(true);
    }

    private void OnDestroy()
    {
        death.OnDie -= ActivateDieCanvas;
    }
}
