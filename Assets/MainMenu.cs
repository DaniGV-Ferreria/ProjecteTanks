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

    public void EscenaJuegoMultiplayer()
    {
        SceneManager.LoadScene("EscenaMultiplayer");
    }

    public void EscenaOptions()
    {
        SceneManager.LoadScene("MenuOptions");
    }

    public void EscenaMenu()
    {
        SceneManager.LoadScene("MenuTanks");
    }

    public void doExitGame()
    {
        UnityEngine.Application.Quit();
    }


}
