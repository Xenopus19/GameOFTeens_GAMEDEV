using System;
using UnityEngine;

public class Level 
{
    public static int level;
    public static float levelTime;
    public static float time;

    public static int boxAmount;

    public static Action OnLevelFinished;

    public static void LoadLevel()
    {
        level = PlayerPrefs.HasKey("Level") ? PlayerPrefs.GetInt("Level") : 1;
        time = 0;
        levelTime = level * 20;
    }

    public static bool IsEndGame()
    {
        return time >= levelTime;
    }

    public static void SaveLevel()
    {
        PlayerPrefs.SetInt("Level", level + 1);
    }
}
