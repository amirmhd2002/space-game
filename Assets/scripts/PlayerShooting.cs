using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;  // Prefab گلوله
    public Transform firePoint;      // نقطه شلیک

    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // شلیک گلوله از نقطه Fire Point
        Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Destroy(bulletPrefab, 3f);
    }
}

