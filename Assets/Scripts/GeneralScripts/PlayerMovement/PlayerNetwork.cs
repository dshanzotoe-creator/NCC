using UnityEngine;
using Unity.Netcode;
public class PlayerNetwork : NetworkBehaviour
{
    PlayerMoving playerMoving;

    private void Awake()
    {
        playerMoving = GetComponent<PlayerMoving>();
    }

    //Rpc is a method that sends the data from this script to the server
    [Rpc(SendTo.Server)]

 
    public void SendInputRpc(Vector2 movementInput, uint tick)
    {
        playerMoving.Movement(movementInput);
    }
}
