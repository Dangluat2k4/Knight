using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemApple : MonoBehaviour
{
    Player player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CharacterStats enemyStats = collision.gameObject.GetComponent<CharacterStats>();
            if (enemyStats != null)
            {
                enemyStats.healing(10); // Giảm 1 HP khi đạn va chạm với Enemy
            }
            Destroy(gameObject); // Hủy đạn sau khi va chạm với Enemy
        }
    }

}
