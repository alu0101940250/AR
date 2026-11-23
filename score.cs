using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public static score Instance;
    public TMP_Text ScoreText;
    private int scoreCount = 0;
    private void Awake()
    {
        Instance = this;
        UpdateScore();
    }

    public void AddPoints(int points)
    {
        scoreCount += points;
        UpdateScore();
    }

    private void UpdateScore()
    {
        if (ScoreText != null)
        {
            ScoreText.text = "Score: " + scoreCount;
        }
    }

}
