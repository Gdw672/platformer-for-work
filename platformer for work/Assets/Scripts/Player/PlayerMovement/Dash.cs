using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dash : MonoBehaviour
{
    private bool isDash;
    private Rigidbody2D playerBody;
    [SerializeField] private float dashPower;
    [SerializeField] private float sumOfDash;
    [SerializeField] private EventTrigger leftBUtton, rightButton;
    private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    public void doDash()
    {
        if(sumOfDash == 1)
        {
            isDash = true;
            StartCoroutine(stopDashCop(0.4f));
            offButtons(true);
        }
    }

    private IEnumerator stopDashCop(float timeOfDash)
    {
        sumOfDash -= 1;

        playerBody.velocity = Vector2.zero;

        playerBody.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;

        if(gameObject.transform.localScale.x > 0) 
        playerBody.velocity = new Vector2(dashPower, 0);

        if(gameObject.transform.localScale.x < 0)
            playerBody.velocity = new Vector2(-dashPower, 0);

        yield return new WaitForSeconds(timeOfDash);

        playerBody.constraints = RigidbodyConstraints2D.FreezeRotation;

        playerBody.velocity = Vector2.zero;

        offButtons(false);

        isDash = false;
    }
    private void offButtons(bool isOff)
    {
        if(isOff)
        {
            leftBUtton.enabled = false;
            rightButton.enabled = false;
        }
        else
        {
            leftBUtton.enabled = true;
            rightButton.enabled = true;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        sumOfDash = 1;
        StartCoroutine(stopDashCop(0f));
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!isDash)
            sumOfDash = 1;
    }
}
