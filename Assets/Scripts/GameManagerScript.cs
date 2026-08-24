using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public bool gameOver = false;

    public int score = 0;

    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;

    void Start()
    {
        Time.timeScale = 1f;

        scoreText.text = score.ToString();

        gameOverScreen.SetActive(false);
    }

    public void AddScore()
    {
        AddScore(1);
    }

    public void AddScore(int points)
    {
        if (gameOver)
        {
            return;
        }

        score++;

        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        if (gameOver)
        {
            return;
        }

        gameOver = true;

        gameOverScreen.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name
        );
    }

}

