using UnityEngine;
using System.Collections;

public class MailBox : MonoBehaviour
{
    public enum Color { R, G, B, Y };
    public Color mailColor;
    public float speed = 3.0f;
    public Sprite[] mailSprites;

    private Rigidbody2D myRigidbody2D;
    private Vector2 newVelocity;
    private SpriteRenderer spriteRenderer;
    private int randomColor;
            
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        newVelocity = new Vector2(speed, 0.0f);
        spriteRenderer = GetComponent<SpriteRenderer>();

        randomColor = Random.Range(0, 4);
        mailColor = (Color)randomColor;
        spriteRenderer.sprite = mailSprites[randomColor];
    }

    void Update()
    {
        myRigidbody2D.velocity = newVelocity;
    }

    public void Pickup()
    {
        Vector2 tempPosition = transform.position;
        tempPosition.x += 2.238989f; //0.114011 -> 2.353
        transform.position = tempPosition;

        newVelocity.x = 0.0f;
    }

    public void Throw()
    {
        newVelocity.x = speed * 2;
    }
}
