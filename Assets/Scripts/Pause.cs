using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    [SerializeField] public GameObject pauseMenue;

    public void PauseMenue()
    {
        pauseMenue.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenue.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Home");
    }
    
        public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
