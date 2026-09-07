using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    CharacterController controller;

    [SerializeField] float movementSpeed = 3f; 


    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }


    public void Movement(Vector2 input)
    {
        Vector3 direction = new Vector3(input.x, 0f, input.y);

        if (direction.magnitude > 1f)
        {
            direction.Normalize();
        }

        Vector3 movement = direction * movementSpeed * Time.deltaTime;

        controller.Move(movement);

    }
}
