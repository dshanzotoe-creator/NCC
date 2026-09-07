using UnityEngine;
using Unity.Netcode;


public class NetworkPlayerController : NetworkBehaviour
{
    private uint tick;
    
    public Vector2 moveInput = Vector2.zero; 

    bool jump = false;

    bool dash = false;

    PlayerNetwork pN;


    private void Awake()
    {
        pN = GetComponent<PlayerNetwork>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }


    private void FixedUpdate()
    {
        UpdateTickRate();
    }



    void PlayerMovement()
    {
        if (!IsOwner)
              return;

        ReadInput();
            
    }

    protected KeyCode ReadInput()
    {
        moveInput = Vector2.zero; 
        KeyCode keyPressed = KeyCode.None;

        if (Input.GetKey(KeyCode.W))
        {
            keyPressed = KeyCode.W;
            moveInput += new Vector2(0, 1); 
           
        }
        if (Input.GetKey(KeyCode.S))
        {
            keyPressed = KeyCode.S;
            moveInput += new Vector2(0, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            keyPressed = KeyCode.D;
            moveInput += new Vector2(1,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            keyPressed = KeyCode.A;
            moveInput += new Vector2(-1, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            keyPressed = KeyCode.LeftShift;
            dash = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            keyPressed = KeyCode.Space;
            jump = true;
        }

        if(keyPressed != KeyCode.None)
        {
            pN.SendInputRpc(moveInput, tick);   
        }

        return keyPressed;
    }

    void UpdateTickRate()
    {
        tick++; 
    }
}
