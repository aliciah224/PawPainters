using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb2D;
    private SpriteRenderer spriteRenderer;
    private float jumpForce;
    private float moveSpeed;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;

    float inputHorizontal;
    float inputVertical;

    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();



        moveSpeed = 2f;
        jumpForce = 60f;
        isJumping = false;

    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");




    }

    void FixedUpdate()
    {
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
            spriteRenderer.flipX = moveHorizontal < 0f;
        }

        if (!isJumping && moveVertical > 0.1f)
        {
            rb2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);

        }


    }







        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Platform")
            {
                isJumping = false;
            }

        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Platform")
            {
                isJumping = true;
            }
        }

   


}
