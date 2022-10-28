using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rigidbodyOfBullet;
    private void Start()
    {
        rigidbodyOfBullet = GetComponent<Rigidbody2D>();
        rigidbodyOfBullet.velocity = new Vector2(-8, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
        Destroy(gameObject);
    }
}
