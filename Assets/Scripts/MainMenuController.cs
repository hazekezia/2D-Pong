using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame(){
        Debug.Log("Jonathan Jeremia Valentino Vici Sitohang - 149251970101-26");
        SceneManager.LoadScene("Game");
    }

    public void OpenAuthor(){
        Debug.Log("Created by Jonathan Jeremia Valentino Vici Sitohang");
    }

    public void Credit(){
        SceneManager.LoadScene("Credit");
    }
}
