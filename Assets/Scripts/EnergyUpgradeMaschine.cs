using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyUpgradeMaschine : MonoBehaviour
{

    public int upgradeLevel;
    public float upgradeCost = 10;


    public CoinManager coinManager;

    // Start is called before the first frame update
    void Start()
    {

        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
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

                    upgradeCost = 20;
                    upgradeLevel += 1;
                }
                break;


            case 1:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;

                    upgradeCost = 30;
                    upgradeLevel += 1;
                }
                break;


            case 2:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;

                    upgradeCost = 40;
                    upgradeLevel += 1;
                }
                break;


            case 3:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.coins -= upgradeCost;

                    upgradeCost = 50;
                    upgradeLevel += 1;
                }
                break;


            case 4:
                if (coinManager.coins >= upgradeCost)
                { 
                    coinManager.coins -= upgradeCost;

                    upgradeCost = 60;
                    upgradeLevel += 1;
                }
                break;



        }
    }
}
