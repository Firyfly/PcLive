using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabyrinthManager : MonoBehaviour
{

    public GameObject[] labyrinths;
    public GameObject outerDoor;
    public GameObject innerDoor;
    public GameObject entrance;
    public GameObject ending;
    public GameObject blackbox;
    public GameObject player;
    public bool endingFinished = false;
    public float time;
    public CoinManager coinManager;
    public GameObject labyrinth;
    public LogicManager logicManager;
    public bool timerActive = false;
    public Text timeText;
    public GameObject timeTextObject;

    // Start is called before the first frame update
    void Start()
    {
        blackbox = GameObject.Find("Blackbox");
        player = GameObject.Find("Player");
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();
        timeTextObject = GameObject.Find("Time");
        timeTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     
        
        if(timerActive == true)
        {
            timeTextObject.SetActive(true);
            timeText.text = "Time left:" + Mathf.Round(time*10f)/10f;
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
                    timeTextObject.SetActive(false);
                }
            }



        }



        

    }

    public void SpawnLabyrinth()
    {
        labyrinth = Instantiate(labyrinths[0], new Vector3(-14.5f, 21.5f, 5.5f), new Quaternion(0, 0, 0, 0));
        SpawnObjects();
        outerDoor.SetActive(false);
        time = 30;
    }

    public void SpawnObjects()
    {
        outerDoor = GameObject.Find("OuterDoor");
        innerDoor = GameObject.Find("InnerDoor");
        entrance = GameObject.Find("Entrance");
        ending = GameObject.Find("Ending");
        
    }


    public void DespawnLabyrinth()
    {
        Destroy(labyrinth);
        time = 0;
    }



    public void StartLabyrinth()
    {

        blackbox.SetActive(false);
        outerDoor.SetActive(true);
        innerDoor.SetActive(false);
        timerActive = true;

    }


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
            timeTextObject.SetActive(false);
        }
    }
    
}
