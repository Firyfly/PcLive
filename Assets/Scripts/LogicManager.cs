using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LogicManager : MonoBehaviour
{

    public float energyAmount;
    public float coolingAmount;

    public float energyMaximum = 120;
    public float coolingMaximum = 120;

    public bool enoughEnergy = true;
    public bool enoughHeat = true;

    public float addCoolingAmount = 5;
    public float addEnergyAmount = 60;

    public CoinManager coinManager;

    void Start()
    {
        //Wenn es das erstmalige Starten ist, dann setze den die Startmenge
        if (PlayerPrefs.GetInt("Once") == 0)
        {
            coolingAmount = 30;
            energyAmount = 30;
            PlayerPrefs.SetInt("Once", 1);
        }
        else//Nach dem ersten starten wird der letzte Wert aus dem Prefab geladen
        {
            coolingAmount = PlayerPrefs.GetFloat("Cooling");
            energyAmount = PlayerPrefs.GetFloat("Energy");
        }

        //Invoke die wiederholenden Funktionen
        InvokeRepeating("DecreaseEnergySlightly", 5f, 20f);
        InvokeRepeating("AddCoolingSlightly", 5f, 4f);
        InvokeRepeating("SaveStatesOfLogic", 5f, 10f);

        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
    }

    void Update()
    {

    }

    //Sinkt leicht die Energie
    public void DecreaseEnergySlightly()
    {
        if (energyAmount > 0)
        {
            energyAmount -= 1;
        }
        else
        {
            energyAmount = 0;
        }
    }

    //Sinkt die Energie
    public void DecreaseEnergy()
    {

        if (energyAmount > 0)
        {
            energyAmount -= 15;
        }
        else
        {
            energyAmount = 0;
        }

    }

    //Steigert die Energie
    public void AddEnergy()
    {
        if (energyAmount < energyMaximum - 60)
        {
            energyAmount += 60;
        }
        else
        {
            energyAmount = energyMaximum;
        }
    }

    //Senkt die Kühlung
    public void DecreaseCooling()
    {
        if (coolingAmount > 0)
        {
            coolingAmount -= 20;
        }
        else
        {
            coolingAmount = 0;
        }
    }

    //Steigert die Kühlung
    public void AddCooling()
    {
        if (coolingAmount < coolingMaximum-5)
        {
            coolingAmount += addCoolingAmount;
        }
        else
        {
            coolingAmount = coolingMaximum;
        }

    }

    //Steigert die Kühlung leicht
    public void AddCoolingSlightly()
    {
        if (coolingAmount < coolingMaximum -0.25f)
        {
            coolingAmount += 0.25f;
        }
        else
        {
            coolingAmount = coolingMaximum;
        }

    }

    //Speichert die Werte
    public void SaveStatesOfLogic()
    {
        PlayerPrefs.SetFloat("Energy",energyAmount);
        PlayerPrefs.SetFloat("Cooling",coolingAmount);
    }



}
