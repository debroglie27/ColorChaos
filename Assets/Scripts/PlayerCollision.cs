using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public SpriteRenderer spriteRenderer;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.collider.tag == "Red" || collisionInfo.collider.tag == "Blue" || collisionInfo.collider.tag == "Green")
        {
            if(spriteRenderer.sprite.name[0] != collisionInfo.collider.tag[0])
            {
                // GAME OVER because player stepped on color other than its own color
                Debug.Log("GameOver!");
            }
        }

        playerMovement.grounded = true;
    }
}
