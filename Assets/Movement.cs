using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movSpeed;
    //float SpeedX, SpeedY;
    private Rigidbody2D rb;
    private Vector2 movDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        //rb.velocity = new Vector2(SpeedX, SpeedY);
    }
    void ProcessInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal") * movSpeed;
        float moveY = Input.GetAxisRaw("Vertical") * movSpeed;

        movDirection = new Vector2(moveX, moveY);
    }

    private void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        rb.velocity = new Vector2(movDirection.x * movSpeed, movDirection.y * movSpeed);
    }
}
