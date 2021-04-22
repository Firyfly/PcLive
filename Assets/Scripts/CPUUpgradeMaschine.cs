using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUUpgradeMaschine : MonoBehaviour
{

    public int upgradeLevel;
    public float upgradeCost;

    public GameObject[] blocks;

    public BinaryManager binaryManager;
    public Conveyor conveyor;
    public SoundManager soundManager;
    public ParticleSystem particles;
    public CoinManager coinManager;

    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        binaryManager = GameObject.Find("BinaryManager").GetComponent<BinaryManager>();
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();

        //Laden der Bereits vorhandenen Upgrades aus den PlayerPrefs
        if (PlayerPrefs.GetInt("UpgradeLevelCPU") == 1)
        {
            upgradeLevel = 1;
            blocks[0].SetActive(true);
            binaryManager.cpuDestroyBlockTime = 4.5f;
            binaryManager.cpuCoinReward = 10;
            upgradeCost = 20;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCPU") == 2)
        {
            upgradeLevel = 2;
            blocks[1].SetActive(true);
            blocks[0].SetActive(true);
            binaryManager.cpuDestroyBlockTime = 4.2f;
            binaryManager.cpuCoinReward = 15;
            upgradeCost = 30;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCPU") == 3)
        {
            upgradeLevel = 3;
            blocks[2].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            binaryManager.cpuDestroyBlockTime = 3.8f;
            binaryManager.cpuCoinReward = 20;
            upgradeCost = 40;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCPU") == 4)
        {
            upgradeLevel = 4;
            blocks[3].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            blocks[2].SetActive(true);
            binaryManager.cpuDestroyBlockTime = 3.4f;
            binaryManager.cpuCoinReward = 25;
            upgradeCost = 50;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelCPU") == 5)
        {
            upgradeLevel = 5;
            blocks[4].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            blocks[2].SetActive(true);
            blocks[3].SetActive(true);
            binaryManager.cpuDestroyBlockTime = 3.0f;
            binaryManager.cpuCoinReward = 30;
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
    public void CPUUpgrade()
    {

        switch (upgradeLevel)
        {
            case 0:

                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    binaryManager.cpuDestroyBlockTime = 4.5f;
                    binaryManager.cpuCoinReward = 10;
                    upgradeCost = 20;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCPU", 1);
                    blocks[0].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying){particles.Play();}

                }
                break;


            case 1:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    binaryManager.cpuDestroyBlockTime = 4.2f;
                    binaryManager.cpuCoinReward = 15;
                    upgradeCost = 30;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCPU", 2);
                    blocks[1].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 2:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    binaryManager.cpuDestroyBlockTime = 3.8f;
                    binaryManager.cpuCoinReward = 20;
                    upgradeCost = 40;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCPU", 3);
                    blocks[2].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 3:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    binaryManager.cpuDestroyBlockTime = 3.4f;
                    binaryManager.cpuCoinReward = 25;
                    upgradeCost = 50;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCPU", 4);
                    blocks[3].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 4:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);
                    binaryManager.cpuDestroyBlockTime = 3.0f;
                    binaryManager.cpuCoinReward = 30;
                    upgradeCost = 0;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelCPU", 5);
                    blocks[4].SetActive(true);
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;
               


        }


    }






}
