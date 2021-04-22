using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QualityOfLifeUpgradeMaschine : MonoBehaviour
{
    public int upgradeLevel;
    public float upgradeCost;

    public GameObject[] blocks;

    public CoinManager coinManager;
    public CubeManager cubeManager;
    public SoundManager soundManager;
    public ParticleSystem particles;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
        cubeManager = GameObject.Find("CubeManager").GetComponent<CubeManager>();

        //Laden der Bereits vorhandenen Upgrades aus den PlayerPrefs
        if (PlayerPrefs.GetInt("UpgradeLevelQualityLife") == 1)
        {
            upgradeLevel = 1;
            blocks[0].SetActive(true);
            cubeManager.lightIntensity = 1;
            upgradeCost = 20;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelQualityLife") == 2)
        {
            upgradeLevel = 2;
            blocks[1].SetActive(true);
            blocks[0].SetActive(true);
            cubeManager.lightIntensity = 2;
            upgradeCost = 30;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelQualityLife") == 3)
        {
            upgradeLevel = 3;
            blocks[2].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            cubeManager.lightIntensity = 4;
            upgradeCost = 40;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelQualityLife") == 4)
        {
            upgradeLevel = 4;
            blocks[3].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            blocks[2].SetActive(true);
            cubeManager.lightIntensity = 6;
            upgradeCost = 50;
        }
        else if (PlayerPrefs.GetInt("UpgradeLevelQualityLife") == 5)
        {
            upgradeLevel = 5;
            blocks[4].SetActive(true);
            blocks[0].SetActive(true);
            blocks[1].SetActive(true);
            blocks[2].SetActive(true);
            blocks[3].SetActive(true);
            cubeManager.lightIntensity = 10;
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
    public void QualityLifeUpgrade()
    {
        switch (upgradeLevel)
        {
            case 0:

                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);

                    upgradeCost = 20;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelQualityLife", 1);
                    blocks[0].SetActive(true);
                    cubeManager.lightIntensity = 1;
                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 1:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);

                    upgradeCost = 30;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelQualityLife", 2);
                    blocks[1].SetActive(true);
            
                    cubeManager.lightIntensity = 2;

                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 2:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);

                    upgradeCost = 40;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelQualityLife", 3);
                    blocks[2].SetActive(true);
            
                    cubeManager.lightIntensity = 4;

                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 3:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);

                    upgradeCost = 50;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelQualityLife", 4);
                    blocks[3].SetActive(true);
    
                    cubeManager.lightIntensity = 6;

                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;


            case 4:
                if (coinManager.coins >= upgradeCost)
                {
                    coinManager.CoinsSub(upgradeCost);

                    upgradeCost = 0;
                    upgradeLevel += 1;
                    PlayerPrefs.SetInt("UpgradeLevelQualityLife", 5);
                    blocks[4].SetActive(true);
     
                    cubeManager.lightIntensity = 10;

                    soundManager.PlayUpgrade();

                    if (!particles.isPlaying) { particles.Play(); }
                }
                break;



        }
    }

}
