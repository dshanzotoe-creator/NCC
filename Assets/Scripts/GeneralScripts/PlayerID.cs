using UnityEngine;
using Unity.Multiplayer.PlayMode;
using Unity.Netcode; 


public class PlayerID : NetworkBehaviour
{
    [SerializeField] ulong clientOwnerID; 



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clientOwnerID = OwnerClientId;
        ChangePlayerName();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void ChangePlayerName()
    {
        gameObject.name = $"Player {clientOwnerID}"; 
    }
}
