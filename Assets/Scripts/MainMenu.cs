using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [Header("Menu")]
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject shopMenu;
    [SerializeField] private GameObject helpMenu;
    [Space(10)]
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private GameObject toggleIcon;
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private Sprite pressedSprite;
    private bool isOn = true;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void GoShop()
    {
        mainMenu.SetActive(false);
        shopMenu.SetActive(true);
    }

    public void ToggleSound()
    {
        isOn = !isOn;
        mixer.SetFloat("Volume", isOn ? 10f : -80f);
        toggleIcon.GetComponent<Image>().sprite = isOn ? defaultSprite : pressedSprite;
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Help()
    {
        mainMenu.SetActive(false);
        helpMenu.SetActive(true);
    }

    public void Back()
    {
        helpMenu.SetActive(false);
        shopMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
