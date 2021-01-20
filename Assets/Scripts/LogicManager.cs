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



    // Start is called before the first frame update
    void Start()
    {
        coolingAmount = 30;
        energyAmount = 30;
        InvokeRepeating("DecreaseEnergySlightly", 5f, 10f);
        InvokeRepeating("AddCoolingSlightly", 5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        










    }


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

    public void DecreaseEnergy()
    {

        if (energyAmount > 0)
        {
            energyAmount -= 5;
        }
        else
        {
            energyAmount = 0;
        }

    }

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

    public void DecreaseCooling()
    {
        if (coolingAmount > 0)
        {
            coolingAmount -= 5;
        }
        else
        {
            coolingAmount = 0;
        }
    }

    public void AddCooling()
    {
        if (coolingAmount < coolingMaximum-5)
        {
            coolingAmount += 5;
        }
        else
        {
            coolingAmount = coolingMaximum;
        }

    }

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





}
