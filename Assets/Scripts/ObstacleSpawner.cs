using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public float spawnInterval = 2f;
    private float timer = 0f;

    private float spawnX;
    private float centerY;

    private void Start()
    {
        float cameraZ = Camera.main.transform.position.z;

        spawnX = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, cameraZ)).x + 1;

        float minY = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, cameraZ)).y;
        float maxY = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, cameraZ)).y;
        centerY = (minY + maxY) / 2f;

    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnInterval)
        { 
            Vector3 spawnPosition = new Vector3(spawnX, centerY, 0f);
            int randomIndex = Random.Range(0, obstaclePrefab.Length);
            GameObject.Instantiate(obstaclePrefab[randomIndex], spawnPosition, Quaternion.identity);
            timer = 0f;
        }
    }
}
