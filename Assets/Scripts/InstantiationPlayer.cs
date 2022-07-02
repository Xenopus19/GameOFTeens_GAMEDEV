using UnityEngine;

public class InstantiationPlayer : MonoBehaviour
{
    [SerializeField] private GameObject[] TransportPrefabs;

    private void Start()
    {
        InstantiatePlayer();
    }

    private void InstantiatePlayer()
    {
        Instantiate(TransportPrefabs[PlayerPrefs.GetInt("Transport")], transform, false);
    }
}
