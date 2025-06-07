using UnityEngine;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("Character Selection");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
