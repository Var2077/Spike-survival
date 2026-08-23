using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 5f;
    public GameManagerScript gameManager;

    void Update()
    {
        if (gameManager.gameOver)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
