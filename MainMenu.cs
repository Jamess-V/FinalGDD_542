using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Flying()
    {
        SceneManager.LoadSceneAsync("Challenge 1");
    }
    
    public void Driving()
    {
        SceneManager.LoadSceneAsync("Prototype 1");
    }
    
    public void Sumo()
    {
        SceneManager.LoadSceneAsync("Challenge 4");
    }
    
    public void OnExit()
    {
        Application.Quit();
    }
}
