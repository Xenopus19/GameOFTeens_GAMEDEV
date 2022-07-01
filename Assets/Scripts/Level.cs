using System;
using UnityEngine;

public class Level
{
    private static int level;
    private static int levelBoxes;

    public static void LoadLevel()
    {
        level = PlayerPrefs.HasKey("Level") ? PlayerPrefs.GetInt("Level") : 0;
        SetBoxesAmount();
    }

    private static void SetBoxesAmount()
    {
        levelBoxes = level * 10;
    }

    public static void CheckEndGame(int score, int num)
    {
        if (score / num == levelBoxes) ;
            //EndGame();
    }
}
