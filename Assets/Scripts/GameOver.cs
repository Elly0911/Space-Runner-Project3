using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject PauseButton; // Add reference to the "Pause Button"

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            GameOverPanel.SetActive(true);
            // Hide the "Pause Button" when game over
            if (PauseButton != null)
            {
                PauseButton.SetActive(false);
            }
        }
    }

    public void Restart()
    {
        // Show the "Pause Button" again when restarting
        if (PauseButton != null)
        {
            PauseButton.SetActive(true);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home()
    {
        SceneManager.LoadScene("Home");
    }
}