using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 5f;  // Topun yatay hareket h�z�
    public float jumpForce = 10f; // Z�plama g�c�

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Yatay hareket (X ekseninde)
        float moveX = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveX * moveSpeed, rb.linearVelocity.y);  // Y ekseni de�i�meden kal�r

        // Z�plama (topun yerde olup olmad���n� kontrol et)
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);  // Yatay hareketi s�f�rla
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);  // Y ekseninde z�plama
        }
    }

    // Zeminle �arp��may� kontrol et
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
