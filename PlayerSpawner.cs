using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab; 
    public Transform spawnPoint; 
    private GameObject playerInstance;

    void Start()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        if (playerInstance != null)
        {
            Destroy(playerInstance); // Destroy the old player instance if it exists
        }
        playerInstance = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    public void RespawnPlayer()
    {
        SpawnPlayer();
    }
}
  
