using UnityEngine;

public class GoldChunkScript : MonoBehaviour
{
    private GameManagerScript gameManager;

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Bird")
        {
            gameManager.AddScore(5);

            Destroy(gameObject);
        }
    }
}