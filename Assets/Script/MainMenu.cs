using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void TombolKeluar()
    {
        Application.Quit();
        Debug.Log("Game.Close");
    }
    public void Mainkan()
    {
        SceneManager.LoadScene("StartAR");
    }
    public void Information()
    {
        SceneManager.LoadScene("Information");
    }
    public void About()
    {
        SceneManager.LoadScene("About");
    }
}
