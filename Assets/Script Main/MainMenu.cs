using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstlevel;
    public GameObject startpage;
    //public string lastlevel;


    public void StartGame()
    {
        SceneManager.LoadScene(firstlevel);
        startpage.SetActive(false);
    }

    public void OpenStory()
    {
        // Create a new story page and use slider to view story
    }

    public void CloseStory()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }

}
