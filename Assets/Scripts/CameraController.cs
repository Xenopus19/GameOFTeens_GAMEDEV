using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    [Header("Menus")]
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject shopMenu;
    [SerializeField] private GameObject helpMenu;
    public void LoadScene()
    {
        SceneManager.LoadScene("Level");
    }

    public void OnShop()
    {
        shopMenu.SetActive(true);
    }

    public void OnHelp()
    {
        helpMenu.SetActive(true);
    }

    public void OnMain()
    {
        mainMenu.SetActive(true);
    }

    public void CloseAll()
    {
        helpMenu.SetActive(false);
        shopMenu.SetActive(false);
        mainMenu.SetActive(false);
    }
}
