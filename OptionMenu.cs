using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMenu : MonoBehaviour
{
    public KeyCode pauseKey = KeyCode.Escape;
    public GameObject PauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            ToggleOptionsMenu();
        }
    }

    public void BacktoMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void resumeGame()
    {

    }
    public void restartGame()
    {
        
    }

}
