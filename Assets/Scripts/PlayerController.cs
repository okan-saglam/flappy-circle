using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    public GameOverManager gameOverManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.linearVelocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Çarptýn! " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Çarptýn!");
            gameOverManager.TriggerGameOver();
        }
    }

}
