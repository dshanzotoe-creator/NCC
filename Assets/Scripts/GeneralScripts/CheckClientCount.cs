using UnityEngine;
using Unity.Netcode; 

public class CheckClientCount : MonoBehaviour
{
    [SerializeField] int playerCount; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        playerCount = GetPlayerCount();
       
    }

    int GetPlayerCount()
    {
        int players = 0;

        if(NetworkManager.Singleton.ConnectedClients.Count == 0 )
             return players;
        else
            players = NetworkManager.Singleton.ConnectedClients.Count;
            return players; 
    }
}
