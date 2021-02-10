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


    // Start is called before the first frame update
    void Start()
    {
        binaryManager = GameObject.Find("BinaryManager").GetComponent<BinaryManager>();
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
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
                }
                break;


            case 1:
                if (coinManager.coins >= upgradeCost)
                {
                    binaryManager.cpuDestroyBlockTime = 4.2f;
                    binaryManager.cpuCoinReward = 10;
                    upgradeCost = 30;
                    upgradeLevel += 1;
                }
                break;


            case 2:
                if (coinManager.coins >= upgradeCost)
                {
                    binaryManager.cpuDestroyBlockTime = 3.8f;
                    binaryManager.cpuCoinReward = 10;
                    upgradeCost = 40;
                    upgradeLevel += 1;
                }
                break;


            case 3:
                if (coinManager.coins >= upgradeCost)
                {
                    binaryManager.cpuDestroyBlockTime = 3.4f;
                    binaryManager.cpuCoinReward = 10;
                    upgradeCost = 50;
                    upgradeLevel += 1;
                }
                break;


            case 4:
                if (coinManager.coins >= upgradeCost)
                {
                    binaryManager.cpuDestroyBlockTime = 3.0f;
                    binaryManager.cpuCoinReward = 10;
                    upgradeCost = 60;
                    upgradeLevel += 1;
                }
                break;
               


        }


    }






}
