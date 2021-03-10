using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyUpgradeMaschine : MonoBehaviour
{

    public int upgradeLevel;
    public float upgradeCost = 10;


    public CoinManager coinManager;

    public GameObject[] blocks;

    public LogicManager logicManager;

    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();

        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();

        if (PlayerPrefs.GetInt("UpgradeLevelEnergy") == 1)
        {
            upgradeLevel = 1;
            blocks[0].SetActive(true);
            logicManager.addEnergyAmount = 70;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelEnergy") == 2)
        {
            upgradeLevel = 2;
            blocks[1].SetActive(true);
            logicManager.addEnergyAmount = 80;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelEnergy") == 3)
        {
            upgradeLevel = 3;
            blocks[2].SetActive(true);
            logicManager.addEnergyAmount = 90;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelEnergy") == 4)
        {
            upgradeLevel = 4;
            blocks[3].SetActive(true);
            logicManager.addEnergyAmount = 100;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelEnergy") == 5)
        {
            upgradeLevel = 5;
            blocks[4].SetActive(true);
            logicManager.addEnergyAmount = 110;
        }
        else
        {
            upgradeLevel = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnergyUpgrade()
    {
        switch (upgradeLevel)
        {
            case 0:

                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;
                    logicManager.addEnergyAmount = 70;
                    upgradeCost = 20;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelEnergy", 1);
                    blocks[0].SetActive(true);
                }
                break;


            case 1:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;
                    logicManager.addEnergyAmount = 80;
                    upgradeCost = 30;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelEnergy", 2);
                    blocks[1].SetActive(true);
                }
                break;


            case 2:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;
                    logicManager.addEnergyAmount = 90;
                    upgradeCost = 40;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelEnergy", 3);
                    blocks[2].SetActive(true);
                }
                break;


            case 3:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;
                    logicManager.addEnergyAmount = 100;
                    upgradeCost = 50;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelEnergy", 4);
                    blocks[3].SetActive(true);
                }
                break;


            case 4:
                if (coinManager.coins >= upgradeCost)
                { 
                    coinManager.coins -= upgradeCost;
                    logicManager.addEnergyAmount = 110;
                    upgradeCost = 60;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelEnergy", 5);
                    blocks[4].SetActive(true);
                }
                break;



        }
    }
}
