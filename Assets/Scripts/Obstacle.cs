using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 2f; // Speed of the obstacle

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Ekrandan çýkýnca yok et
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
