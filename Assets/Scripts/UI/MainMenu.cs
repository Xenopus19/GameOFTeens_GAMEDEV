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
    private bool isOn = true;
    [SerializeField] private Animator animator;

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
        mixer.SetFloat("Volume", isOn ? 10f : -80f);
        toggleIcon.GetComponent<Image>().sprite = isOn ? defaultSprite : pressedSprite;
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
