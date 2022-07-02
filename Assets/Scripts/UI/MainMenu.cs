using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private GameObject toggleIcon;
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private Sprite pressedSprite;
    private bool isOn;
    [SerializeField] private Animator animator;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Sound"))
        {
            if (PlayerPrefs.GetInt("Sound") == 0)
            {
                isOn = true;
            }
            else if (PlayerPrefs.GetInt("Sound") == 1)
            {
                isOn = false;
            }
        }
        else
        {
            isOn = true;
        }

        mixer.SetFloat("Volume", isOn ? 0f : -80f);
        toggleIcon.GetComponent<Image>().sprite = isOn ? defaultSprite : pressedSprite;
        PlayerPrefs.SetInt("Sound", isOn ? 0 : 1);
    }

    public void Play()
    {
        animator.SetBool("isPlay", true);
    }

    public void GoShop()
    {
        animator.SetBool("isShop", true);
    }

    public void Help()
    {
        animator.SetBool("isHelp", true);    
    }

    public void Back()
    {
        animator.SetBool("isHelp", false);
        animator.SetBool("isShop", false);       
    }

    public void ToggleSound()
    {
        isOn = !isOn;
        mixer.SetFloat("Volume", isOn ? 0f : -80f);
        toggleIcon.GetComponent<Image>().sprite = isOn ? defaultSprite : pressedSprite;
        PlayerPrefs.SetInt("Sound", isOn ? 0 : 1);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
