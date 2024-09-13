using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthHUD : MonoBehaviour
{
    public TextMeshProUGUI healthText; 
    public PlayerHealth playerHealth; 

    void Update()
    {
        if (playerHealth != null && healthText != null)
        {
            healthText.text = "Health: " + playerHealth.GetCurrentHealth() + "/" + playerHealth.GetMaxHealth();
        }
    }
}

