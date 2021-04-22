using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Läd die Hauptscene
    public void PlayGame()
    {
        SceneManager.LoadScene("PcLive");
    }

    //Schließt das Spiel
    public void QuitGame()
    {
        Application.Quit();
    }


}
