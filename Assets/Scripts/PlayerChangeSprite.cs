using UnityEngine;

public class PlayerChangeSprite : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteList;
    static int spriteIndex = 0;
    
    void Update()
    {
        if(Input.GetKeyDown("e") && !playerMovement.grounded)
        {
            ChangeSprite();
        }
    }
    void ChangeSprite()
    {
        spriteIndex = (spriteIndex + 1) % 3;
        spriteRenderer.sprite = spriteList[spriteIndex];
    }
}
