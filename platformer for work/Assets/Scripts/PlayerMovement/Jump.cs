using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private List<string> allTagsToPlusJump;
    private int sumOfJump = 2;
    private Rigidbody2D playerBody;
    


    private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sumOfJump = 2;
    }
    public void jump()
    {
        if(sumOfJump > 0)
        {
            playerBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            sumOfJump -= 1;
        }
    }
}
