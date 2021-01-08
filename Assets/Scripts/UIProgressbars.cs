using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIProgressbars : MonoBehaviour
{

    public float maximumEnergy;
    public float currentEnergy;
    public Image maskEnergy;

    public float maximumCooling;
    public float currentCooling;
    public Image maskCooling;

    private LogicManager logicManager;



    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        currentEnergy = logicManager.energyAmount;
        currentCooling = logicManager.coolingAmount;
        maximumEnergy = logicManager.energyMaximum;
        maximumCooling = logicManager.coolingMaximum;

        GetCurrentFillEnergy();
        GetCurrentFillCooling();
    }


    public void GetCurrentFillEnergy()
    {
        float fillAmount = currentEnergy / maximumEnergy;
        maskEnergy.fillAmount = fillAmount;
    }
    public void GetCurrentFillCooling()
    {
        float fillAmount = currentCooling / maximumCooling;
        maskCooling.fillAmount = fillAmount;
    }
}
