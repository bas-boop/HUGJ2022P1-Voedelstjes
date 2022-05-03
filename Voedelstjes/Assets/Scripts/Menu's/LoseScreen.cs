using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    public void MainMenu()
    {
        //SceneManager.LoadScene("");
    }

    public void Restart()
    {
        SceneManager.LoadScene("PlayerSlecetScreen");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
