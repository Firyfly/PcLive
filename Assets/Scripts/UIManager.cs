using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public GameObject resumeButton;
    public GameObject menuButton;

    public bool menuOpen;
    public bool once = true;

    void Start()
    {
        resumeButton.SetActive(false);
        menuButton.SetActive(false);
        menuOpen = false;
    }

    void Update()
    {
        //Öffne/Schließe das InGameMenü
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Wenn Menü geöffnet ist, schließe es
            if (menuOpen == true)
            {
                menuOpen = false;
                resumeButton.SetActive(false);
                menuButton.SetActive(false);
                once = false;
            }
            //Wenn Menü geschlossen ist, öffne es
            if (menuOpen == false && once == true)
            {
                resumeButton.SetActive(true);
                menuButton.SetActive(true);

                menuOpen = true;
            }
            once = true;

        }
    }

    //Schließt das Menü
    public void ResumeGame()
    {
        menuOpen = false;
        resumeButton.SetActive(false);
        menuButton.SetActive(false);
    }

    //Läd die Szene zum Hauptmenü
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }



}
