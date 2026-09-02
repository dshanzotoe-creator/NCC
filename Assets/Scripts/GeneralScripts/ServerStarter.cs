using UnityEngine;
using Unity.Multiplayer.PlayMode;
using Unity.Netcode;

public class ServerStarter : MonoBehaviour
{
    bool isMainEditor = false;

    private void Awake()
    {
        isMainEditor = CurrentPlayer.IsMainEditor; 
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Checking whether the client is the main editor to set it as the server or set it as a client.
        if (isMainEditor)
        {
            NetworkManager.Singleton.StartServer();
        }
        else
        {
            NetworkManager.Singleton.StartClient();
        }
    }

    // Update is called once per frame
    void Update()
    {
      

    }
}
