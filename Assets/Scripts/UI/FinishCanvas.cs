using System.Collections;
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
        int score = Score.Instance.score;
        float scoreForStar = (Level.boxAmount / 2) * BoxScript.scoreAddAmount;
        if (score >= scoreForStar) 
            stars[0].SetActive(true);

        yield return new WaitForSeconds(0.5f);

        if (score >= scoreForStar + Enemy.EnemyReward * Level.level) 
            stars[1].SetActive(true);

        yield return new WaitForSeconds(0.5f);

        if (score >= scoreForStar + Enemy.EnemyReward * Level.level * 1.5)
            stars[2].SetActive(true);

    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
