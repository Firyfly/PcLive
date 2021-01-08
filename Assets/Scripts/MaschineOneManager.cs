using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaschineOneManager : MonoBehaviour
{
    //public bool test = true;

    public float coinGeneration = 0;
    public float maschineLevel = 0;
    public float upgradeCost = 1;
    public GameObject upgradeButton;

    private CoinManager coinManager;

    // Start is called before the first frame update
    void Start()
    {
        upgradeButton = GameObject.Find("UpgradeButton");
        upgradeButton.SetActive(false);
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
        InvokeRepeating("UpdateAddCoins", 0.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateAddCoins()
    {
        //if(coinGeneration>0){};
        coinManager.CoinsAdd(coinGeneration);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            upgradeButton.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            upgradeButton.SetActive(false);
        }
    }


    //void OnTriggerStay(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //    }
    //}

    public void UpgradeMachineLevel()
    {
        if (coinManager.coins >= upgradeCost) // test = false
        {
            coinManager.CoinsSub(upgradeCost);
            maschineLevel += 1;
            upgradeCost = upgradeCost * 2;
            coinGeneration += 1;

        }
    }

    //public void Test()
    //{
    //    coinManager.CoinsSub(10);
    //}
}
