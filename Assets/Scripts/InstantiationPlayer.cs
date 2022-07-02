using UnityEngine;

public class InstantiationPlayer : MonoBehaviour
{
    [SerializeField] private GameObject[] TransportPrefabs;

    void Awake()
    {
        InstantiatePlayer();
    }

    private void InstantiatePlayer()
    {
        Instantiate(TransportPrefabs[SavingTransport.TransportIndex], gameObject.transform, false);
    }
}
