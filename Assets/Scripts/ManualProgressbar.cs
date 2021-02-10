using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualProgressbar : MonoBehaviour
{
    public GameObject[] energySpheres;
    public GameObject[] coolingSpheres;

    public LogicManager logicManager;

    public Material grey;
    public Material blue;
    public Material yellow;

    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logicManager.energyAmount / logicManager.energyMaximum > 1.0f)
        {
            energySpheres[0].GetComponent<Renderer>().material = yellow;
            energySpheres[1].GetComponent<Renderer>().material = yellow;
            energySpheres[2].GetComponent<Renderer>().material = yellow;
            energySpheres[3].GetComponent<Renderer>().material = yellow;
            energySpheres[4].GetComponent<Renderer>().material = yellow;
        }
        if (logicManager.energyAmount/logicManager.energyMaximum < 1.0f && logicManager.energyAmount / logicManager.energyMaximum > 0.8f)
        {
            energySpheres[0].GetComponent<Renderer>().material = yellow;
            energySpheres[1].GetComponent<Renderer>().material = yellow;
            energySpheres[2].GetComponent<Renderer>().material = yellow;
            energySpheres[3].GetComponent<Renderer>().material = yellow;
            energySpheres[4].GetComponent<Renderer>().material = grey;
            
        }
        if ( logicManager.energyAmount/logicManager.energyMaximum  < 0.8f &&  logicManager.energyAmount / logicManager.energyMaximum  > 0.6f)
        {
            energySpheres[0].GetComponent<Renderer>().material = yellow;
            energySpheres[1].GetComponent<Renderer>().material = yellow;
            energySpheres[2].GetComponent<Renderer>().material = yellow;
            energySpheres[3].GetComponent<Renderer>().material = grey;
            energySpheres[4].GetComponent<Renderer>().material = grey;
        }
        if (logicManager.energyAmount/logicManager.energyMaximum   < 0.6f && logicManager.energyAmount/logicManager.energyMaximum   > 0.4f)
        {
            energySpheres[0].GetComponent<Renderer>().material = yellow;
            energySpheres[1].GetComponent<Renderer>().material = yellow;
            energySpheres[2].GetComponent<Renderer>().material = grey;
            energySpheres[3].GetComponent<Renderer>().material = grey;
            energySpheres[4].GetComponent<Renderer>().material = grey;
        }
        if (logicManager.energyAmount/logicManager.energyMaximum   < 0.4f && logicManager.energyAmount/logicManager.energyMaximum  > 0.2f)
        {
            energySpheres[0].GetComponent<Renderer>().material = yellow;
            energySpheres[1].GetComponent<Renderer>().material = grey;
            energySpheres[2].GetComponent<Renderer>().material = grey;
            energySpheres[3].GetComponent<Renderer>().material = grey;
            energySpheres[4].GetComponent<Renderer>().material = grey;
        }
        if (logicManager.energyAmount/logicManager.energyMaximum   < 0.2f)
        {
            energySpheres[0].GetComponent<Renderer>().material = grey;
            energySpheres[1].GetComponent<Renderer>().material = grey;
            energySpheres[2].GetComponent<Renderer>().material = grey;
            energySpheres[3].GetComponent<Renderer>().material = grey;
            energySpheres[4].GetComponent<Renderer>().material = grey;
        }





        if (logicManager.coolingAmount / logicManager.coolingMaximum > 1.0)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = blue;
            coolingSpheres[1].GetComponent<Renderer>().material = blue;
            coolingSpheres[2].GetComponent<Renderer>().material = blue;
            coolingSpheres[3].GetComponent<Renderer>().material = blue;
            coolingSpheres[4].GetComponent<Renderer>().material = blue;

        }

        if (logicManager.coolingAmount / logicManager.coolingMaximum < 1.0 && logicManager.coolingAmount / logicManager.coolingMaximum > 0.8)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = blue;
            coolingSpheres[1].GetComponent<Renderer>().material = blue;
            coolingSpheres[2].GetComponent<Renderer>().material = blue;
            coolingSpheres[3].GetComponent<Renderer>().material = blue;
            coolingSpheres[4].GetComponent<Renderer>().material = grey;
            
        }
        if (logicManager.coolingAmount / logicManager.coolingMaximum < 0.8 && logicManager.coolingAmount / logicManager.coolingMaximum > 0.6)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = blue;
            coolingSpheres[1].GetComponent<Renderer>().material = blue;
            coolingSpheres[2].GetComponent<Renderer>().material = blue;
            coolingSpheres[3].GetComponent<Renderer>().material = grey;
            coolingSpheres[4].GetComponent<Renderer>().material = grey;
        }
        if (logicManager.coolingAmount / logicManager.coolingMaximum < 0.6 && logicManager.coolingAmount / logicManager.coolingMaximum > 0.4)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = blue;
            coolingSpheres[1].GetComponent<Renderer>().material = blue;
            coolingSpheres[2].GetComponent<Renderer>().material = grey;
            coolingSpheres[3].GetComponent<Renderer>().material = grey;
            coolingSpheres[4].GetComponent<Renderer>().material = grey;
        }
        if (logicManager.coolingAmount / logicManager.coolingMaximum < 0.4 && logicManager.coolingAmount / logicManager.coolingMaximum > 0.2)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = blue;
            coolingSpheres[1].GetComponent<Renderer>().material = grey;
            coolingSpheres[2].GetComponent<Renderer>().material = grey;
            coolingSpheres[3].GetComponent<Renderer>().material = grey;
            coolingSpheres[4].GetComponent<Renderer>().material = grey;
        }
        if (logicManager.coolingAmount / logicManager.coolingMaximum < 0.2)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = grey;
            coolingSpheres[1].GetComponent<Renderer>().material = grey;
            coolingSpheres[2].GetComponent<Renderer>().material = grey;
            coolingSpheres[3].GetComponent<Renderer>().material = grey;
            coolingSpheres[4].GetComponent<Renderer>().material = grey;
        }







    }
}
