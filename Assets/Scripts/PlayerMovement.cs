using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;   
    public float moveSpeed = 8;
    public float jumpSpeed = 10;
    public bool grounded = false;

    void Update()    
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRigidbody.velocity = new Vector2(horizontalInput * moveSpeed, playerRigidbody.velocity.y);

        if(Input.GetKey("space") && grounded)
        {
            Jump();
        }     
    }

    void Jump()
    {
        grounded = false;
        playerRigidbody.velocity = Vector2.up * jumpSpeed;
    }
}
