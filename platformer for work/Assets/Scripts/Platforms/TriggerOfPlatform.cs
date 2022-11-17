using UnityEngine;

public class TriggerOfPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.parent.tag = "Untagged";
            ClimbButton.getSingltone().gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.parent.tag = "ClimbPlatform";
        }
    }
}
