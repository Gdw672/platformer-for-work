using UnityEngine;

public class PointsOfCamera : MonoBehaviour
{
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
