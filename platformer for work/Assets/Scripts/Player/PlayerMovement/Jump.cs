using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
    
    [SerializeField] private Vector2 directionJumpFromWall;
    [SerializeField] private float jumpForce;
    private int sumOfJump = 2;
    private Rigidbody2D playerBody;
    
    
    private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.transform.position.y > collision.transform.position.y)
        sumOfJump = 2;
    }

    public void generalJump()
    {
        if (sumOfJump > 0 && !ClimbButton.getSingltone().gameObject.activeSelf)
        {
            defaultJump();
        }
    }
    private void defaultJump()
    {
            playerBody.velocity = Vector2.zero;
            playerBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            sumOfJump -= 1;
    }

   
}
