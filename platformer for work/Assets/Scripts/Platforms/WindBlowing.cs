using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBlowing : MonoBehaviour
{
    private Rigidbody2D playerBody;

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerBody = collision.gameObject.GetComponent<Rigidbody2D>();
            playerBody.velocity = new Vector2(0, 10);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerBody = collision.gameObject.GetComponent<Rigidbody2D>();
            playerBody.velocity = new Vector2(0, 10);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        playerBody.velocity = new Vector2(0, 10);
    }
}
