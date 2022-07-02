using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance;
    public Score()
    {
        Instance = this;
    }

    public int score = 0;
    private Text scoreText;

    void Start()
    {
        scoreText = gameObject.GetComponent<Text>();
        Level.LoadLevel();
        UpdateScoreText();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            score += 10;
            UpdateScoreText();
        }
    }

    public void AddScore(int num)
    {
        score += num;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "" + score;
    }
}
