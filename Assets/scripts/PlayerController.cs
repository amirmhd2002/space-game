using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // سرعت حرکت فضاپیما
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // دریافت کامپوننت Rigidbody2D
        rb.gravityScale = 0;
    }

    void Update()
    {
        // دریافت ورودی از کلیدهای جهت‌دار
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // محاسبه حرکت
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
      
        // حرکت فضاپیما با استفاده از Rigidbody2D
        rb.linearVelocity = movement * moveSpeed;

        // جلوگیری از خروج فضاپیما از محدوده (اختیاری)
        rb.position = new Vector2(
            Mathf.Clamp(rb.position.x, -8f, 8f), // محدود کردن محور X
            Mathf.Clamp(rb.position.y, -4f, 4f) // محدود کردن محور Y
        );
    }
}
