using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
   private Rigidbody2D playerBody;
   private bool isPressed;
   private float speedOfWalk;
   [SerializeField] private float sizePlayer;

    private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        sizePlayer = gameObject.transform.localScale.x;
    }

    public void tranformateSizePlayer(bool isLeft)
    {
        if(isLeft)
        {
            gameObject.transform.localScale = new Vector3(-sizePlayer, -sizePlayer, -sizePlayer);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(sizePlayer, sizePlayer, sizePlayer);
        }
    }

    public void OnDowm(float speed)
    {
        speedOfWalk = speed;
        isPressed = true;
    }

    public void OnUp()
    {
        isPressed = false;
    }

    private void FixedUpdate()
    {
        if(isPressed)
        {
            playerBody.transform.Translate(speedOfWalk, 0, 0);
        }
    }
}
