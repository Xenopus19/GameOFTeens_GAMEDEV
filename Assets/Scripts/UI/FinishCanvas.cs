using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishCanvas : MonoBehaviour
{
    [SerializeField] private GameObject[] stars;
    private void Start()
    {
        StartCoroutine(nameof(InitStars));
    }

    private IEnumerator InitStars()
    {
        Debug.Log("Stars activated");
        int score = Score.Instance.score;

        if(score < Level.levelBoxes/2 * 50) 
            stars[0].SetActive(true);

        yield return new WaitForSeconds(0.5f);

        if (score >= Level.levelBoxes/2 * 50 + 25*5) 
            stars[1].SetActive(true);

        yield return new WaitForSeconds(0.5f);

        if (score >= Level.levelBoxes/2 * 50 + 25 * 10) 
            stars[2].SetActive(true);

    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
