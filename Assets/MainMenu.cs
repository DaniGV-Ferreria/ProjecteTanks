using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EscenaMultiplayer()
    {
        SceneManager.LoadScene("EscenaMultiplayer");
    }

    public void EscenaOptions()
    {
        SceneManager.LoadScene("EscenaMenuOptions");
    }

    public void EscenaMenu()
    {
        SceneManager.LoadScene("EscenaMenuTanks");
    }

    public void EscenaSingleplayer1()
    {
        SceneManager.LoadScene("EscenaLevelOne");
    }

    public void EscenaSingleplayer2()
    {
        SceneManager.LoadScene("EscenaLevelTwo");
    }

    public void EscenaSingleplayer3()
    {
        SceneManager.LoadScene("EscenaLevelThree");
    }

    public void EscenaSeleccioLevel()
    {
        SceneManager.LoadScene("EscenaSeleccioLevel");
    }

    public void doExitGame()
    {
        UnityEngine.Application.Quit();
    }


}
