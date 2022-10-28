using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsOfCamera : MonoBehaviour
{
  


    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        print("errew");
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            changePosition();
        }
    }

    void changePosition()
    {
        Camera.main.gameObject.transform.position = gameObject.transform.GetChild(0).position;
    }
}
