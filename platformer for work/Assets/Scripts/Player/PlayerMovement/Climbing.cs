using UnityEngine;

public class Climbing : MonoBehaviour
{
    [SerializeField] private float speedOfClimg;
    private Walking walking;
    private Rigidbody2D rigidbodyOfPlayer;
    private bool isPressed;
    private void Start()
    {
        walking = GetComponent<Walking>();
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
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ClimbPlatform")
        {
            rigidbodyOfPlayer.velocity = Vector2.zero;
            walking.isPressed = false;
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
