using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            restartGame();
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(0);
    }
}
