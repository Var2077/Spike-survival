using UnityEngine;

public class GoldChunkScript : MonoBehaviour
{
    private GameManagerScript gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Bird")
        {
            gameManager.AddScore(5);

            SoundManagerScript.instance.PlayGoldSound();

            Destroy(gameObject);
        }
    }
}
