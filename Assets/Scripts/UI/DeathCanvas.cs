using UnityEngine;

public class DeathCanvas : MonoBehaviour
{
    [SerializeField] private GameObject deathCanvas;
    [SerializeField] private GameObject Road;
    [SerializeField] private GameObject CarMusic;
    private PlayerDeath death;

    void Start()
    {
        death = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDeath>();
        death.OnDie += ActivateDieCanvas;
    }

    private void ActivateDieCanvas()
    {
        deathCanvas.SetActive(true);
        Road.SetActive(false);
        CarMusic.SetActive(false);
    }

    private void OnDestroy()
    {
        death.OnDie -= ActivateDieCanvas;
    }
}
