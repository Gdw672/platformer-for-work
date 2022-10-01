using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour
{
    private Rigidbody2D rigidbodyOfPlayer;
    private bool isPressed;
    [SerializeField] private float speedOfClimg;
    private void Start()
    {
        rigidbodyOfPlayer = GetComponent<Rigidbody2D>();
        ClimbButton.getSingltone().velocityZero += VelocityZero;
    }

    public void onDownUp(bool pressed)
    {
        isPressed = pressed;
    }

    private void VelocityZero()
    {
        rigidbodyOfPlayer.velocity = Vector2.zero;
        isPressed = false;
        print("worked");
    }

    public void FreezePlayerY(bool isFreeze)
    {
        if(isFreeze)
            rigidbodyOfPlayer.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;

        else
            rigidbodyOfPlayer.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    private void FixedUpdate()
    {
        if(isPressed)
        {
            rigidbodyOfPlayer.velocity = Vector2.up * speedOfClimg;
            print("YES");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ClimbPlatform")
        {
            ClimbButton.getSingltone().gameObject.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ClimbPlatform")
        {
            ClimbButton.getSingltone().gameObject.SetActive(false);
        }
    }
}
