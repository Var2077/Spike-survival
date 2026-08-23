using UnityEngine;

public class SpikeSpawnerScript : MonoBehaviour
{
    public GameObject spikePair;
    public float spawnRate = 2f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnSpike();
            timer = 0f;
        }
    }

    void SpawnSpike()
    {
        float lowestPoint = -0.8f;
        float highestPoint = 0.8f;

        float randomY = Random.Range(lowestPoint, highestPoint);


        Vector3 spawnPosition = new Vector3(
            transform.position.x,
            randomY,
            transform.position.z
        );

        Instantiate(spikePair, spawnPosition, transform.rotation);
    }
}
