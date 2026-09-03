using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class SpawnPointHandler : NetworkBehaviour
{

    [Header("Variables")]
    [SerializeField] GameObject[] spawnPoints = new GameObject[2];
    [SerializeField] GameObject[] players = new GameObject[2];

    private void Awake()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        if (players.Length > 0)
            AssignPlayerToSpawnPoint();
    }


    void AssignPlayerToSpawnPoint()
    {
        for (int i = 0; i < players.Length && i < spawnPoints.Length; i++)
        {
            players[i].transform.position = spawnPoints[i].transform.position;
        }
    }
}
