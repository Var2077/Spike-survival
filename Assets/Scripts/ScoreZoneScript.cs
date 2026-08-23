using UnityEngine;

public class ScoreZoneScript : MonoBehaviour
{
    public GameManagerScript gameManager;

    private bool hasScored = false;

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (hasScored)
        {
            return;
        }

        if (other.gameObject.name == "Bird")
        {
            gameManager.AddScore();
            hasScored = true;
        }
    }
}