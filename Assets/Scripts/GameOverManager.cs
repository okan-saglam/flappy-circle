using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject restartButton;

    private bool isGameOver = false;

    private void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }

    public void TriggerGameOver()
    {
        gameOverText.SetActive(true);
        //restartButton.SetActive(true);
        isGameOver = true;
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1; // Oyun zamanýný baþlat
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }
}
