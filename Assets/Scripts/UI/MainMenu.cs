using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [Header("Menus")]
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject shopMenu;
    [SerializeField] private GameObject helpMenu;
    [Space(10)]
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private GameObject toggleIcon;
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private Sprite pressedSprite;
    private bool isOn = true;
    [SerializeField] private Animator animator;

    public void Play()
    {
        animator.SetBool("isPlay", true);
        mainMenu.SetActive(false);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Level");
    }

    public void GoTo(GameObject to)
    {
        CloseAll();
        to.SetActive(true);
    }

    public void CloseAll()
    {
        helpMenu.SetActive(false);
        shopMenu.SetActive(false);
        mainMenu.SetActive(false);
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
}
