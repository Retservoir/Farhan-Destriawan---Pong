using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created By Farhan Destriawan");
    }

    public void PlayCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void PlayMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Farhan Destriawan");
    }
}

