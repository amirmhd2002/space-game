using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float speed = 5f;  // سرعت حرکت فضاپیما

    void Update()
    {
        // حرکت فضاپیما به سمت پایین
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // اگر فضاپیما از پایین صفحه خارج شد، آن را حذف کنید
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
