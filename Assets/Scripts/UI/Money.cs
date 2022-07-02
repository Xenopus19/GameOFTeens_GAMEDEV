using UnityEngine;

public class Money : MonoBehaviour
{
    public static int Coins;

    void Start()
    {
        LoadMoney();
        Level.OnLevelFinished += IncreaseByScore;
    }

    private void LoadMoney()
    {
        Coins = PlayerPrefs.HasKey("Money") ? PlayerPrefs.GetInt("Money") : 0;
    }

    public void IncreaseByScore()
    {
        Coins += Score.Instance.score;
        SaveMoney();
    }

    private static void SaveMoney()
    {
        PlayerPrefs.SetInt("Money", Coins);
        print (Coins);
    }

    private static void SpentMoney(int purchase)
    {
        Coins -= purchase;
        SaveMoney();
    }

    public void IncreaseMoney(int toAdd)
    {
        Coins += toAdd;
        SaveMoney();
    }

    private void OnDestroy()
    {
        Level.OnLevelFinished -= IncreaseByScore;
    }
}
