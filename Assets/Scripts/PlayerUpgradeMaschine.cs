using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpgradeMaschine : MonoBehaviour
{
    public int upgradeLevel;
    public float upgradeCost;

    public GameObject[] blocks;

    public CoinManager coinManager;
    public PlayerController playerController;
    public SoundManager soundManager;
    public ParticleSystem particles;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

        //Laden der Bereits vorhandenen Upgrades aus den PlayerPrefs
        if (PlayerPrefs.GetInt("UpgradeLevelPlayer") == 1)
        {
            upgradeLevel = 1;
            blocks[0].SetActive(true);
            playerController.playerSpeed = 6;
            upgradeCost = 20;
            
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelPlayer") == 2)
        {
            upgradeLevel = 2;

            blocks[1].SetActive(true);
            blocks[0].SetActive(true);
            playerController.playerSpeed = 7;
            upgradeCost = 30;

        }
        else if (PlayerPrefs.GetInt("UpgradeLevelPlayer") == 3)
        {
            upgradeLevel = 3;
            blocks[2].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            playerController.playerSpeed = 8;
            upgradeCost = 40;

        }
        else if (PlayerPrefs.GetInt("UpgradeLevelPlayer") == 4)
        {
            upgradeLevel = 4;
            blocks[3].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            blocks[2].SetActive(true);
            playerController.playerSpeed = 9;
            upgradeCost = 50;

        }
        else if (PlayerPrefs.GetInt("UpgradeLevelPlayer") == 5)
        {
            upgradeLevel = 5;
            blocks[4].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            blocks[2].SetActive(true);
            blocks[3].SetActive(true);
            playerController.playerSpeed = 10;
            upgradeCost = 0;

        }
        else
        {
            upgradeLevel = 0;
            upgradeCost = 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Funktion welche zum Upgraden der Maschine aufgerufen wird, welche das Upgradelevel erhöht und die betroffenen variablen ändert
    public void PlayerUpgrade()
    {
        switch (upgradeLevel)
        {
            case 0:

                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    playerController.playerSpeed = 6;
                    upgradeCost = 20;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelPlayer", 1);
                    blocks[0].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 1:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    playerController.playerSpeed = 7;
                    upgradeCost = 30;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelPlayer", 2);
                    blocks[1].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 2:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    playerController.playerSpeed = 8;
                    upgradeCost = 40;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelPlayer", 3);
                    blocks[2].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 3:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    playerController.playerSpeed = 9;
                    upgradeCost = 50;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelPlayer", 4);
                    blocks[3].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 4:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    playerController.playerSpeed = 10;
                    upgradeCost = 0;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelPlayer", 5);
                    blocks[4].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;



        }
    }

}
