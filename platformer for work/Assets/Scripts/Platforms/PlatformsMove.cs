using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsMove : MonoBehaviour
{
    [SerializeField] private float speedOfPlatform;
    private Rigidbody2D rigidbodyOfPlatform;
    [SerializeField] private float distanceOfPlatform;
    private float platformPassed;




    private void Start()
    {
        rigidbodyOfPlatform = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(Mathf.Abs(platformPassed) < Mathf.Abs(distanceOfPlatform))
        {
            rigidbodyOfPlatform.transform.Translate(speedOfPlatform, 0, 0);
            platformPassed += speedOfPlatform;
        }
        else
        {
            speedOfPlatform = -speedOfPlatform;
            platformPassed = 0;
        }
      
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            LinkToPlayerParentObj.getSingltone().gameObject.transform.parent = gameObject.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            LinkToPlayerParentObj.getSingltone().gameObject.transform.parent = null;
        }
    }


}