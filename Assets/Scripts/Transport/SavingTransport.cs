using UnityEngine;

public class SavingTransport : MonoBehaviour
{
    public static int TransportIndex;

    void Awake()
    {
        TransportIndex = PlayerPrefs.HasKey("Transport") ? PlayerPrefs.GetInt("Transport") - 1 : 0;
        transform.GetChild(TransportIndex).gameObject.SetActive(true);
    }
}
