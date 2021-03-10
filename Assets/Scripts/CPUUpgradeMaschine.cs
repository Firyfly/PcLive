using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUUpgradeMaschine : MonoBehaviour
{

    public int upgradeLevel;
    public float upgradeCost = 10;

    public BinaryManager binaryManager;
    public Conveyor conveyor;

    public CoinManager coinManager;

    public GameObject[] blocks;


    // Start is called before the first frame update
    void Start()
    {
        binaryManager = GameObject.Find("BinaryManager").GetComponent<BinaryManager>();
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();

        if(PlayerPrefs.GetInt("UpgradeLevelCPU") == 1)
        {
            upgradeLevel = 1;
            blocks[0].SetActive(true);
            binaryManager.cpuDestroyBlockTime = 4.5f;
            binaryManager.cpuCoinReward = 10;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCPU") == 2)
        {
            upgradeLevel = 2;
            blocks[1].SetActive(true);
            binaryManager.cpuDestroyBlockTime = 4.2f;
            binaryManager.cpuCoinReward = 15;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCPU") == 3)
        {
            upgradeLevel = 3;
            blocks[2].SetActive(true);
            binaryManager.cpuDestroyBlockTime = 3.8f;
            binaryManager.cpuCoinReward = 20;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCPU") == 4)
        {
            upgradeLevel = 4;
            blocks[3].SetActive(true);
            binaryManager.cpuDestroyBlockTime = 3.4f;
            binaryManager.cpuCoinReward = 25;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCPU") == 5)
        {
            upgradeLevel = 5;
            blocks[4].SetActive(true);
            binaryManager.cpuDestroyBlockTime = 3.0f;
            binaryManager.cpuCoinReward = 30;
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


    public void CPUUpgrade()
    {

        switch (upgradeLevel)
        {
            case 0:

                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;
                    binaryManager.cpuDestroyBlockTime = 4.5f;
                    binaryManager.cpuCoinReward = 10;
                    upgradeCost = 20;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCPU", 1);
                    blocks[0].SetActive(true);
                }
                break;


            case 1:
                if (coinManager.coins >= upgradeCost)
                {
                    binaryManager.cpuDestroyBlockTime = 4.2f;
                    binaryManager.cpuCoinReward = 15;
                    upgradeCost = 30;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCPU", 2);
                    blocks[1].SetActive(true);
                }
                break;


            case 2:
                if (coinManager.coins >= upgradeCost)
                {
                    binaryManager.cpuDestroyBlockTime = 3.8f;
                    binaryManager.cpuCoinReward = 20;
                    upgradeCost = 40;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCPU", 3);
                    blocks[2].SetActive(true);
                }
                break;


            case 3:
                if (coinManager.coins >= upgradeCost)
                {
                    binaryManager.cpuDestroyBlockTime = 3.4f;
                    binaryManager.cpuCoinReward = 25;
                    upgradeCost = 50;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCPU", 4);
                    blocks[3].SetActive(true);
                }
                break;


            case 4:
                if (coinManager.coins >= upgradeCost)
                {
                    binaryManager.cpuDestroyBlockTime = 3.0f;
                    binaryManager.cpuCoinReward = 30;
                    upgradeCost = 60;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCPU", 5);
                    blocks[4].SetActive(true);
                }
                break;
               


        }


    }






}
