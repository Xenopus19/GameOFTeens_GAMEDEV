using System;
using UnityEngine;

public class Level 
{
    public static float levelBoxes;

    public static int level;
    private static float allBoxes;

    public static Action<float> OnBoxAmountChanged;
    public static Action OnLevelFinished;

    public static void LoadLevel()
    {
        level = PlayerPrefs.HasKey("Level") ? PlayerPrefs.GetInt("Level") : 1;
        allBoxes = 0;
        SetBoxesAmount();
    }

    private static void SetBoxesAmount()
    {
        levelBoxes = level * 10;
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
