using UnityEngine;

public class GameManager : MonoBehaviour
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

        GameObject spaceShip = Instantiate(spaceshipPrefab, spawnPosition, Quaternion.identity);

        Vector3 endPoint = new Vector3(spawnPosition.x, -6.56f, 0);
     
        if (spaceShip != null ) {
    }
}
