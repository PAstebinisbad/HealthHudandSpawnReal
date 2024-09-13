using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealOrb : MonoBehaviour
{
    public int healAmount = 10; // Amount of health restored
    public float destroyDelay = 0.1f; // Delay before destruction

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.Heal(healAmount);
            }
            // Destroy this object after a short delay
            Destroy(gameObject, destroyDelay);
        }
    }
}
