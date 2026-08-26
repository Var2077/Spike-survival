using UnityEngine;

public class GoldSpawnerScript : MonoBehaviour
{
    public GameObject goldChunk;

    public float minSpawnTime = 3f;
    public float maxSpawnTime = 6f;
    public float lowestPoint = -3.5f;
    public float highestPoint = 3.5f;
    private float timer = 0f;
    private float nextSpawnTime;

    private void Start()
    {
        SetNextSpawnTime();
    }
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= nextSpawnTime)
        {
            SpawnGold();
            timer = 0f;
            SetNextSpawnTime();
        }
    }

    void SetNextSpawnTime()
    {
        nextSpawnTime = Random.Range(
            minSpawnTime,
            maxSpawnTime
        );
    }

    void SpawnGold()
{
    Camera mainCamera = Camera.main;

    float halfScreenWidth =
        mainCamera.orthographicSize * mainCamera.aspect;

    float randomX = Random.Range(
        mainCamera.transform.position.x + 1.5f,
        mainCamera.transform.position.x + halfScreenWidth * 0.8f
    );

    float randomY;

    int positionType = Random.Range(0, 3);

    if (positionType == 0)
    {
        // Lower risky position
        randomY = Random.Range(-3.5f, -2f);
    }
    else if (positionType == 1)
    {
        // Middle position
        randomY = Random.Range(-1.5f, 1.5f);
    }
    else
    {
        // Upper risky position
        randomY = Random.Range(2f, 3.5f);
    }

    Vector3 spawnPosition = new Vector3(
        randomX,
        randomY,
        0f
    );

    Instantiate(
        goldChunk,
        spawnPosition,
        Quaternion.identity
    );
} 
}