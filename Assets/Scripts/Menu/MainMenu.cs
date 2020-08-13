using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGameEasy()
    {
        SceneManager.LoadScene("TutorialLevelEasy");
    }

    public void PlayGameHard()
    {
        SceneManager.LoadScene("TutorialLevelHard");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
