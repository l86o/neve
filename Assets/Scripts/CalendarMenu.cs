using UnityEngine;
using UnityEngine.SceneManagement;

public class CalendarMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
      
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
      
    }


    public void Restart()
    {
        SceneManager.LoadScene("Main");
      
    }

}
