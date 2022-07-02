using UnityEngine;

public class Money : MonoBehaviour
{
    public static int Coins;

    void Start()
    {
        LoadMoney();
        Level.OnLevelFinished += IncreaseByScore;
    }

    public static int LoadMoney()
    {
        Coins = PlayerPrefs.HasKey("Money") ? PlayerPrefs.GetInt("Money") : 0;
        return Coins;
    }

    public void IncreaseByScore()
    {
        Coins += Score.Instance.score;
        SaveMoney();
    }

    public static void SaveMoney()
    {
        PlayerPrefs.SetInt("Money", Coins);
    }

    public static void SpentMoney(int purchase)
    {
        Coins -= purchase;
        SaveMoney();
    }

    public static void IncreaseMoney(int toAdd)
    {
        Coins += toAdd;
        SaveMoney();
    }

    private void OnDestroy()
    {
        Level.OnLevelFinished -= IncreaseByScore;
    }
}
