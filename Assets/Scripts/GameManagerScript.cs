using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public bool gameOver = false;

    public void GameOver()
    {
        gameOver = true;
        Debug.Log("OOF GAME OVER!");
    }

}