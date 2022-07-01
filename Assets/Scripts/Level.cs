using System;
using UnityEngine;

public class Level 
{
    private static int level;
    private static float levelBoxes;
    private static float caughtBoxes;
    private static float allBoxes;

    public static Action<float> OnBoxAmountChanged;

    public static void LoadLevel()
    {
        level = PlayerPrefs.HasKey("Level") ? PlayerPrefs.GetInt("Level") : 1;
        SetBoxesAmount();
    }

    private static void SetBoxesAmount()
    {
        levelBoxes = level * 100;
    }

    public static void IncreaseCaughtBoxAmount()
    {
        caughtBoxes++;
    }

    public static void IncreaseAllBoxAmount(GameObject box)
    {
        if (box.GetComponent<BoxScript>() != null)
        {
            allBoxes++;
            OnBoxAmountChanged?.Invoke(allBoxes / levelBoxes);
        }
    }

    internal static bool IsEndGame()
    {
        return allBoxes == levelBoxes;
    }
}