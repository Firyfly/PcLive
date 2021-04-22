using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Collider upgradeCollider;

    public Vector3 moveUp;
    public Vector3 moveDown;
    public Vector3 moveLeft;
    public Vector3 moveRight;
    public Vector3 oldPos;

    public float playerSpeed = 100;
    public float playerPositionY;

    public bool triggered = false;

    public float walkTimer = 0.5f;

    public float upgradeWaitTime = 0;
    public bool upgrading = false;
    public float upgradeCost;

    public SoundManager soundManager;
    public CubeManager cubeManager;
    public LabyrinthManager labyrinthManager;
    public FollowPlayerZAxis followPlayerZAxis;
    public CPUUpgradeMaschine cpuUpgradeMaschine;
    public EnergyUpgradeMaschine energyUpgradeMaschine;
    public CoolingUpgradeMaschine coolingUpgradeMaschine;
    public PlayerUpgradeMaschine playerUpgradeMaschine;
    public QualityOfLifeUpgradeMaschine qualityOfLifeUpgradeMaschine;

    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        cubeManager = GameObject.Find("CubeManager").GetComponent<CubeManager>();
        labyrinthManager = GameObject.Find("LabyrinthManager").GetComponent<LabyrinthManager>();
        followPlayerZAxis = GameObject.Find("MainCamera").GetComponent<FollowPlayerZAxis>();
        cpuUpgradeMaschine = GameObject.Find("CPUUpgradeMaschine").GetComponent<CPUUpgradeMaschine>();
        energyUpgradeMaschine = GameObject.Find("EnergyUpgradeMaschine").GetComponent<EnergyUpgradeMaschine>();
        coolingUpgradeMaschine = GameObject.Find("CoolingUpgradeMaschine").GetComponent<CoolingUpgradeMaschine>();
        playerUpgradeMaschine = GameObject.Find("PlayerUpgradeMaschine").GetComponent<PlayerUpgradeMaschine>();
        qualityOfLifeUpgradeMaschine = GameObject.Find("QualityOfLifeUpgradeMaschine").GetComponent<QualityOfLifeUpgradeMaschine>();

        moveUp = new Vector3(0, 1, 0);
        moveDown = new Vector3(0, -1, 0);
        moveLeft = new Vector3(-1, 0, 0);
        moveRight = new Vector3(1, 0, 0);

        oldPos = this.gameObject.transform.position;

    }
    

    void Update()
    {
        //Timer für den Lauf Sound
        if(oldPos != this.gameObject.transform.position)
        {
            walkTimer -= Time.deltaTime;
            if (walkTimer <= 0)
            {
                soundManager.PlayWalk();
                walkTimer = 0.5f;
            }
        }

        oldPos = this.gameObject.transform.position;
        playerPositionY = transform.position.y;

        //Spieler bewegung WASD
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(moveUp * playerSpeed * Time.deltaTime,Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(moveDown * playerSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(moveLeft * playerSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveRight * playerSpeed * Time.deltaTime, Space.World);
        }

        //Wartezeit für Upgrades, damit diese nicht ausversehen passieren oder verbuggen
        if (upgradeWaitTime > 0)
        {
            upgradeWaitTime -= Time.deltaTime;
        }


        //Wenn der Spieler in einem Upgradebereich ist
        if(upgrading == true)
        {
                //Wenn Spieler bei der CPUUpgradeMaschine ist wird die upgradecost angepasst und falls "E" gedrückt wird die nötige Funktion aufgerufen
                if (upgradeCollider.tag == "CPUUpgradeMaschine")
                {
                    upgradeCost = cpuUpgradeMaschine.upgradeCost;
                    
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (upgradeWaitTime <= 0)
                        {
                            cpuUpgradeMaschine.CPUUpgrade();
                            upgradeWaitTime = 1;
                        }
                    }
                }
                //Wenn Spieler bei der EnergyUpgradeMaschine ist wird die upgradecost angepasst und falls "E" gedrückt wird die nötige Funktion aufgerufen
                if (upgradeCollider.tag == "EnergyUpgradeMaschine")
                {
                    upgradeCost = energyUpgradeMaschine.upgradeCost;

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (upgradeWaitTime <= 0)
                        {
                            energyUpgradeMaschine.EnergyUpgrade();
                            upgradeWaitTime = 1;
                        }
                    }
                }
                //Wenn Spieler bei der CoolingUpgradeMaschine ist wird die upgradecost angepasst und falls "E" gedrückt wird die nötige Funktion aufgerufen
                if (upgradeCollider.tag == "CoolingUpgradeMaschine")
                {
                    upgradeCost = coolingUpgradeMaschine.upgradeCost;

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (upgradeWaitTime <= 0)
                        {
                            coolingUpgradeMaschine.CoolingUpgrade();
                            upgradeWaitTime = 1;
                        }
                    }
                }
                //Wenn Spieler bei der PlayerUpgradeMaschine ist wird die upgradecost angepasst und falls "E" gedrückt wird die nötige Funktion aufgerufen
                if (upgradeCollider.tag == "PlayerUpgradeMaschine")
                {
                    upgradeCost = playerUpgradeMaschine.upgradeCost;

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (upgradeWaitTime <= 0)
                        {
                            playerUpgradeMaschine.PlayerUpgrade();
                            upgradeWaitTime = 1;
                        }
                    }
                }
                //Wenn Spieler bei der QualityOfLifeUpgradeMaschine ist wird die upgradecost angepasst und falls "E" gedrückt wird die nötige Funktion aufgerufen
                if (upgradeCollider.tag == "QualityOfLifeUpgradeMaschine")
                {
                    upgradeCost = qualityOfLifeUpgradeMaschine.upgradeCost;  

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (upgradeWaitTime <= 0)
                        {
                            qualityOfLifeUpgradeMaschine.QualityLifeUpgrade();
                            upgradeWaitTime = 1;
                        }
                    }
                }
            
        }





    }

    //Aktiviert die Collider abhängigen Funktionen und ändert ggf. die Variablen
    void OnTriggerEnter(Collider other)
    {

        cubeManager.SwitchSides(other);

        labyrinthManager.InteractLabyrinth(other);

        if(other.tag == "CPUUpgradeMaschine" || other.tag == "EnergyUpgradeMaschine" || other.tag == "CoolingUpgradeMaschine" || other.tag == "PlayerUpgradeMaschine" || other.tag == "QualityOfLifeUpgradeMaschine")
        {
            upgradeCollider = other;
            upgrading = true;
        }

    }

    //Setzt upgrading auf false wenn der upgradebereich verlassen wird
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "CPUUpgradeMaschine" || other.tag == "EnergyUpgradeMaschine" || other.tag == "CoolingUpgradeMaschine" || other.tag == "PlayerUpgradeMaschine" || other.tag == "QualityOfLifeUpgradeMaschine")
        {
            upgrading = false;
        }
    }


}
