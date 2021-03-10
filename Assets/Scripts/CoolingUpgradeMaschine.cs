using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolingUpgradeMaschine : MonoBehaviour
{

    public int upgradeLevel;
    public float upgradeCost = 10;

    public CoinManager coinManager;

    public GameObject[] blocks;

    public IceCreation iceCreation;
    public LogicManager logicManager;

    // Start is called before the first frame update
    void Start()
    {
        iceCreation = GameObject.Find("IceGenerator").GetComponent<IceCreation>();
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();

        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();

        if (PlayerPrefs.GetInt("UpgradeLevelCooling") == 1)
        {
            upgradeLevel = 1;
            blocks[0].SetActive(true);
            iceCreation.timeMax = 9;
      
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCooling") == 2)
        {
            upgradeLevel = 2;
            blocks[1].SetActive(true);
            iceCreation.timeMax = 9;
            logicManager.addCoolingAmount = 7;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCooling") == 3)
        {
            upgradeLevel = 3;
            blocks[2].SetActive(true);
            iceCreation.timeMax = 8;
            logicManager.addCoolingAmount = 7;

        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCooling") == 4)
        {
            upgradeLevel = 4;
            blocks[3].SetActive(true);
            iceCreation.timeMax = 8;
            logicManager.addCoolingAmount = 9;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCooling") == 5)
        {
            upgradeLevel = 5;
            blocks[4].SetActive(true);
            iceCreation.timeMax = 7;
            logicManager.addCoolingAmount = 10;
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

    public void CoolingUpgrade()
    {
        switch (upgradeLevel)
        {
            case 0:

                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;
                    iceCreation.timeMax = 9;
                    upgradeCost = 20;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCooling", 1);
                    blocks[0].SetActive(true);
                }
                break;


            case 1:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;
                    logicManager.addCoolingAmount = 7;
                    upgradeCost = 30;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCooling", 2);
                    blocks[1].SetActive(true);
                }
                break;


            case 2:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;
                    iceCreation.timeMax = 8;
                    upgradeCost = 40;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCooling", 3);
                    blocks[2].SetActive(true);
                }
                break;


            case 3:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;
                    logicManager.addCoolingAmount = 9;
                    upgradeCost = 50;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCooling", 4);
                    blocks[3].SetActive(true);
                }
                break;


            case 4:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;
                    iceCreation.timeMax = 7;
                    logicManager.addCoolingAmount = 10;
                    upgradeCost = 60;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCooling", 5);
                    blocks[4].SetActive(true);
                }
                break;



        }
    }

}
