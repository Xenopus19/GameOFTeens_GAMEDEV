using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCanvas : MonoBehaviour
{
    [SerializeField] private GameObject[] stars;
    private void Start()
    {
        StartCoroutine(nameof(InitStars));
    }

    private IEnumerable InitStars()
    {
        int score = Score.Instance.score;

        if(score < Level.levelBoxes * 100) stars[0].SetActive(true);

        yield return new WaitForSeconds(0.5f);

        if (score >= Level.levelBoxes * 100 + 25*5) stars[1].SetActive(true);

        yield return new WaitForSeconds(0.5f);

        if (score >= Level.levelBoxes * 100 + 25 * 10) stars[2].SetActive(true);

    }
}
