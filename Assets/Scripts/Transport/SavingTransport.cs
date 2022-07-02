using UnityEngine;

public class SavingTransport : MonoBehaviour
{
    public static int TransportIndex;

    private void Awake()
    {
        TransportIndex = PlayerPrefs.HasKey("Transport") ? PlayerPrefs.GetInt("Transport") : 0;
        SaveTransport(TransportIndex);
        transform.GetChild(TransportIndex).gameObject.SetActive(true);
    }

    public static void SaveTransport(int number)
    {
        PlayerPrefs.SetInt("Transport", number);
    }
}
