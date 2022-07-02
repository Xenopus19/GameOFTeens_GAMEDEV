using UnityEngine;

public class InstantiationPlayer : MonoBehaviour
{
    [SerializeField] private GameObject[] TransportPrefabs;
    [SerializeField] private GameObject PlayerHpUI;

    void Awake()
    {
        InstantiatePlayer();
    }

    private void InstantiatePlayer()
    {
        GameObject transport = Instantiate(TransportPrefabs[SavingTransport.TransportIndex], transform, false);
        transport.GetComponent<Health>().thisHealthUI = PlayerHpUI;
    }
}
