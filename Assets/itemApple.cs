using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemApple : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("tăng hp");
            // Gửi sự kiện hoặc gọi phương thức để thông báo rằng người chơi đã chạm vào item quả táo
            collision.gameObject.GetComponent<Player>().OnAppleCollected();
            // Sau đó, hủy bỏ đối tượng item quả táo
            Destroy(gameObject);
        }
    }
}
