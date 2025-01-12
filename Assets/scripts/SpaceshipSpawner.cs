using UnityEngine;

public class SpaceshipSpawner : MonoBehaviour
{
    public GameObject spaceshipPrefab;  // Prefab فضاپیما
    public float spawnInterval = 2f;    // فاصله زمانی بین هر تولید

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer >= spawnInterval)
        {
            SpawnSpaceship();
            timer = 0f;
        }
    }

    void SpawnSpaceship()
    {
        float randomX = Random.Range(-8f, 8f);  // موقعیت تصادفی در محور X
        Vector3 spawnPosition = new Vector3(randomX, 5.65f, 0f);  // موقعیت بالای صفحه

        Instantiate(spaceshipPrefab, spawnPosition, Quaternion.identity);
    }
}
