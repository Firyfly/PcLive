using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyUpgradeMaschine : MonoBehaviour
{

    public int upgradeLevel;
    public float upgradeCost;

    public GameObject[] blocks;

    public CoinManager coinManager;
    public LogicManager logicManager;
    public SoundManager soundManager;
    public ParticleSystem particles;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();

        //Laden der Bereits vorhandenen Upgrades aus den PlayerPrefs
        if (PlayerPrefs.GetInt("UpgradeLevelEnergy") == 1)
        {
            upgradeLevel = 1;
            blocks[0].SetActive(true);
            logicManager.addEnergyAmount = 70;
            upgradeCost = 20;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelEnergy") == 2)
        {
            upgradeLevel = 2;
            blocks[1].SetActive(true);
            blocks[0].SetActive(true);
            logicManager.addEnergyAmount = 80;
            upgradeCost = 30;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelEnergy") == 3)
        {
            upgradeLevel = 3;
            blocks[2].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            logicManager.addEnergyAmount = 90;
            upgradeCost = 40;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelEnergy") == 4)
        {
            upgradeLevel = 4;
            blocks[3].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            blocks[2].SetActive(true);
            logicManager.addEnergyAmount = 100;
            upgradeCost = 50;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelEnergy") == 5)
        {
            upgradeLevel = 5;
            blocks[4].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            blocks[2].SetActive(true);
            blocks[3].SetActive(true);
            logicManager.addEnergyAmount = 110;
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
    public void EnergyUpgrade()
    {
        switch (upgradeLevel)
        {
            case 0:

                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    logicManager.addEnergyAmount = 70;
                    upgradeCost = 20;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelEnergy", 1);
                    blocks[0].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 1:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    logicManager.addEnergyAmount = 80;
                    upgradeCost = 30;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelEnergy", 2);
                    blocks[1].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 2:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    logicManager.addEnergyAmount = 90;
                    upgradeCost = 40;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelEnergy", 3);
                    blocks[2].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 3:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    logicManager.addEnergyAmount = 100;
                    upgradeCost = 50;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelEnergy", 4);
                    blocks[3].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 4:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    logicManager.addEnergyAmount = 110;
                    upgradeCost = 0;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelEnergy", 5);
                    blocks[4].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;



        }
    }
}
