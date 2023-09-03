using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    private Rigidbody2D ballRB;
    private Rigidbody2D fanRB;

    [SerializeField] private float fanForce = 10f;
    [SerializeField] private float moveSpeed = 7f;

    private void Start()
    {
        fanRB = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            ballRB = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ballRB = null;
    }

    private void Update()
    {
        LiftBall();
        MoveFan();
    }

    private void MoveFan()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        fanRB.velocity = new Vector2(dirX * moveSpeed, fanRB.velocity.y);
    }

    private void LiftBall()
    {
        if (ballRB != null)
        {
            ballRB.velocity = new Vector2(ballRB.velocity.x, fanForce);
        }
    }
    
}
