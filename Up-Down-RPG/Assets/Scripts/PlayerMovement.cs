using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed;
    private Rigidbody2D body;
    private BoxCollider2D boxCollider;
    private float horizontalInput;
    private float verticalInput;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }    
    
    
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Flip player when moving left-right
        if (horizontalInput> 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput< -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        body.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);
    }
}
