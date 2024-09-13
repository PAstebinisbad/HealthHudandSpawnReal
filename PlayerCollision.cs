using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerHealth playerHealth; // Reference to PlayerHealth script

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Deal 1 damage to the player
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(1);
            }

            // Destroy the enemy
            Destroy(collision.gameObject);
        }
    }
}