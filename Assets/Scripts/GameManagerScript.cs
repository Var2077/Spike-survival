using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public bool gameOver = false;

    public int score = 0;

    public TextMeshProUGUI scoreText;

    void Start()
    {
        Time.timeScale = 1f;
        scoreText.text = score.ToString();
    }

    public void AddScore()
    {
        if (gameOver)
        {
            return;
        }

        score++;

        scoreText.text = score.ToString();

        Debug.Log("Score: " + score);
    }

    public void GameOver()
    {
        if (gameOver)
        {
            return;
        }

        gameOver = true;

        Debug.Log("GAME OVER!");

        Time.timeScale = 0f;
    }
}