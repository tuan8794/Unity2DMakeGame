//using UnityEditorInternal;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;
    private AudioManager audioManager;
    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        audioManager = FindAnyObjectByType<AudioManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coin"))
        {
            Destroy(collision.gameObject);
            audioManager.PlayCoinSound();
            gameManager.Addsore(1);
            //   Debug.Log("Hit Coin");
        }
        else if (collision.CompareTag("Trap"))
        {
            gameManager.GameOver();
           // Debug.Log("Ui dau qua di");
        }
        else if (collision.CompareTag("Enemy"))
        {
            gameManager.GameOver();
        }
        else if (collision.CompareTag("key"))
        {
            Destroy(collision.gameObject);
            gameManager.GameWin();
        }
    }  
}
