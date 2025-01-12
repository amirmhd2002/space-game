using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // حرکت گلوله به سمت بالا
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // چک کردن خروج از محدوده بازی و حذف گلوله
        if (transform.position.y > 11f) // تغییر مقدار Y بر اساس محدوده بازی شما
        {
            Destroy(gameObject);  // حذف گلوله
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);  // حذف گلوله پس از برخورد
    }
}

