using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabyrinthManager : MonoBehaviour
{
    public bool endingFinished = false;
    public float time;
    public bool timerActive = false;

    public GameObject[] labyrinths;
    public GameObject outerDoor;
    public GameObject innerDoor;
    public GameObject entrance;
    public GameObject ending;
    public GameObject blackbox;
    public GameObject player;
    public GameObject labyrinth;
    public Text timeText;
    public GameObject timeTextObject;
    public GameObject[] spheres;
    public Material black;
    public Material white;

    public CoinManager coinManager;
    public SoundManager soundManager;
    public LogicManager logicManager;
    public ParticleSystem endingParticles;

    void Start()
    {
        blackbox = GameObject.Find("Blackbox");
        player = GameObject.Find("Player");
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();
        timeTextObject = GameObject.Find("Time");
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {
     
        //Timer für das Labyrinth
        if(timerActive == true)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
            }
            else
            {
                if (endingFinished == false)
                {
                    player.transform.position = new Vector3(-14, 20, 10);
                    blackbox.SetActive(true);
                    timerActive =false;
                    soundManager.StopTimer();
                }
            }

            //Manuelle Anzeige der Lichter passend zur vergangenen Zeit
            if(time <= 28)
            {
                spheres[14].GetComponent<Renderer>().material = black;
            }
            if (time <= 26)
            {
                spheres[13].GetComponent<Renderer>().material = black;
            }
            if (time <= 24)
            {
                spheres[12].GetComponent<Renderer>().material = black;
            }
            if (time <= 22)
            {
                spheres[11].GetComponent<Renderer>().material = black;
            }
            if (time <= 20)
            {
                spheres[10].GetComponent<Renderer>().material = black;
            }
            if (time <= 18)
            {
                spheres[9].GetComponent<Renderer>().material = black;
            }
            if (time <= 16)
            {
                spheres[8].GetComponent<Renderer>().material = black;
            }
            if (time <= 14)
            {
                spheres[7].GetComponent<Renderer>().material = black;
            }
            if (time <= 12)
            {
                spheres[6].GetComponent<Renderer>().material = black;
            }
            if (time <= 10)
            {
                spheres[5].GetComponent<Renderer>().material = black;
            }
            if (time <= 8)
            {
                spheres[4].GetComponent<Renderer>().material = black;
            }
            if (time <= 6)
            {
                spheres[3].GetComponent<Renderer>().material = black;
            }
            if (time <= 4)
            {
                spheres[2].GetComponent<Renderer>().material = black;
            }
            if (time <= 2)
            {
                spheres[1].GetComponent<Renderer>().material = black;
            }
            if (time <= 0)
            {
                spheres[0].GetComponent<Renderer>().material = black;
            }

        }



        

    }

    //Spawnt das Labyrinth und bereitet alle Objekte und Variablen vor
    public void SpawnLabyrinth()
    {
        int rand = Random.Range(0, 3);
        labyrinth = Instantiate(labyrinths[rand], new Vector3(-14.5f, 21.5f, 5.5f), new Quaternion(0, 0, 0, 0));
        SpawnObjects();
        outerDoor.SetActive(false);
        time = 30;

        //Setze alle Lichter auf Weiß
        for(int i = 0; i <= 14; i++)
        {
            spheres[i].GetComponent<Renderer>().material = white;
        }

    }

    //Setzt die Objekte auf die Variablen
    public void SpawnObjects()
    {
        outerDoor = GameObject.Find("OuterDoor");
        innerDoor = GameObject.Find("InnerDoor");
        entrance = GameObject.Find("Entrance");
        ending = GameObject.Find("Ending");
        
    }

    //Beendet das Labyrinth und zerstört das alte Prefab
    public void DespawnLabyrinth()
    {
        Destroy(labyrinth);
        time = 0;
    }


    //Startet das Labyrinth und den Timer
    public void StartLabyrinth()
    {
        blackbox.SetActive(false);
        outerDoor.SetActive(true);
        innerDoor.SetActive(false);
        timerActive = true;

        soundManager.PlayLabyrinthStart();
        soundManager.PlayTimer();
    }

    //Fängt alle Interaktionen im Labyrinth ab
    public void InteractLabyrinth(Collider other)
    {
        if (other.tag == "Entrance")
        {
            StartLabyrinth();
        }
        if (other.tag == "Ending")
        {
            player.transform.position = new Vector3(-14,20,10);
            endingFinished = true;
            blackbox.SetActive(true);
            logicManager.AddEnergy();
            timerActive = false;
            soundManager.PlayElectricity();
            soundManager.StopTimer();
            endingParticles.Play();

            //Setze alle Lichter auf Schwarz nach dem ende des Labyrinths
            for(int i = 0; i <= 14; i++)
            {
                spheres[i].GetComponent<Renderer>().material = black;
            }
        }
    }
    
}
