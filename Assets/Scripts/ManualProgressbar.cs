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
            energySpheres[0].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[1].GetComponent<Renderer>().material = yellow;
            energySpheres[1].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[2].GetComponent<Renderer>().material = yellow;
            energySpheres[2].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[3].GetComponent<Renderer>().material = yellow;
            energySpheres[3].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[4].GetComponent<Renderer>().material = yellow;
            energySpheres[4].transform.Find("Light").gameObject.SetActive(true);
        }
        if (logicManager.energyAmount/logicManager.energyMaximum < 1.0f && logicManager.energyAmount / logicManager.energyMaximum > 0.8f)
        {
            energySpheres[0].GetComponent<Renderer>().material = yellow;
            energySpheres[0].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[1].GetComponent<Renderer>().material = yellow;
            energySpheres[1].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[2].GetComponent<Renderer>().material = yellow;
            energySpheres[2].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[3].GetComponent<Renderer>().material = yellow;
            energySpheres[3].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[4].GetComponent<Renderer>().material = grey;
            energySpheres[4].transform.Find("Light").gameObject.SetActive(false);
        }
        if ( logicManager.energyAmount/logicManager.energyMaximum  < 0.8f &&  logicManager.energyAmount / logicManager.energyMaximum  > 0.6f)
        {
            energySpheres[0].GetComponent<Renderer>().material = yellow;
            energySpheres[0].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[1].GetComponent<Renderer>().material = yellow;
            energySpheres[1].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[2].GetComponent<Renderer>().material = yellow;
            energySpheres[2].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[3].GetComponent<Renderer>().material = grey;
            energySpheres[3].transform.Find("Light").gameObject.SetActive(false);
            energySpheres[4].GetComponent<Renderer>().material = grey;
            energySpheres[4].transform.Find("Light").gameObject.SetActive(false);
        }
        if (logicManager.energyAmount/logicManager.energyMaximum   < 0.6f && logicManager.energyAmount/logicManager.energyMaximum   > 0.4f)
        {
            energySpheres[0].GetComponent<Renderer>().material = yellow;
            energySpheres[0].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[1].GetComponent<Renderer>().material = yellow;
            energySpheres[1].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[2].GetComponent<Renderer>().material = grey;
            energySpheres[2].transform.Find("Light").gameObject.SetActive(false);
            energySpheres[3].GetComponent<Renderer>().material = grey;
            energySpheres[3].transform.Find("Light").gameObject.SetActive(false);
            energySpheres[4].GetComponent<Renderer>().material = grey;
            energySpheres[4].transform.Find("Light").gameObject.SetActive(false);
        }
        if (logicManager.energyAmount/logicManager.energyMaximum   < 0.4f && logicManager.energyAmount/logicManager.energyMaximum  > 0.2f)
        {
            energySpheres[0].GetComponent<Renderer>().material = yellow;
            energySpheres[0].transform.Find("Light").gameObject.SetActive(true);
            energySpheres[1].GetComponent<Renderer>().material = grey;
            energySpheres[1].transform.Find("Light").gameObject.SetActive(false);
            energySpheres[2].GetComponent<Renderer>().material = grey;
            energySpheres[2].transform.Find("Light").gameObject.SetActive(false);
            energySpheres[3].GetComponent<Renderer>().material = grey;
            energySpheres[3].transform.Find("Light").gameObject.SetActive(false);
            energySpheres[4].GetComponent<Renderer>().material = grey;
            energySpheres[4].transform.Find("Light").gameObject.SetActive(false);
        }
        if (logicManager.energyAmount/logicManager.energyMaximum   < 0.2f)
        {
            energySpheres[0].GetComponent<Renderer>().material = grey;
            energySpheres[0].transform.Find("Light").gameObject.SetActive(false);
            energySpheres[1].GetComponent<Renderer>().material = grey;
            energySpheres[1].transform.Find("Light").gameObject.SetActive(false);
            energySpheres[2].GetComponent<Renderer>().material = grey;
            energySpheres[2].transform.Find("Light").gameObject.SetActive(false);
            energySpheres[3].GetComponent<Renderer>().material = grey;
            energySpheres[3].transform.Find("Light").gameObject.SetActive(false);
            energySpheres[4].GetComponent<Renderer>().material = grey;
            energySpheres[4].transform.Find("Light").gameObject.SetActive(false);
        }







        if (logicManager.coolingAmount / logicManager.coolingMaximum > 1.0f)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = blue;
            coolingSpheres[0].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[1].GetComponent<Renderer>().material = blue;
            coolingSpheres[1].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[2].GetComponent<Renderer>().material = blue;
            coolingSpheres[2].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[3].GetComponent<Renderer>().material = blue;
            coolingSpheres[3].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[4].GetComponent<Renderer>().material = blue;
            coolingSpheres[4].transform.Find("Light").gameObject.SetActive(true);

        }

        if (logicManager.coolingAmount / logicManager.coolingMaximum < 1.0f && logicManager.coolingAmount / logicManager.coolingMaximum > 0.8f)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = blue;
            coolingSpheres[0].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[1].GetComponent<Renderer>().material = blue;
            coolingSpheres[1].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[2].GetComponent<Renderer>().material = blue;
            coolingSpheres[2].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[3].GetComponent<Renderer>().material = blue;
            coolingSpheres[3].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[4].GetComponent<Renderer>().material = grey;
            coolingSpheres[4].transform.Find("Light").gameObject.SetActive(false);

        }
        if (logicManager.coolingAmount / logicManager.coolingMaximum < 0.8f && logicManager.coolingAmount / logicManager.coolingMaximum > 0.6f)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = blue;
            coolingSpheres[0].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[1].GetComponent<Renderer>().material = blue;
            coolingSpheres[1].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[2].GetComponent<Renderer>().material = blue;
            coolingSpheres[2].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[3].GetComponent<Renderer>().material = grey;
            coolingSpheres[3].transform.Find("Light").gameObject.SetActive(false);
            coolingSpheres[4].GetComponent<Renderer>().material = grey;
            coolingSpheres[4].transform.Find("Light").gameObject.SetActive(false);
        }
        if (logicManager.coolingAmount / logicManager.coolingMaximum < 0.6f && logicManager.coolingAmount / logicManager.coolingMaximum > 0.4f)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = blue;
            coolingSpheres[0].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[1].GetComponent<Renderer>().material = blue;
            coolingSpheres[1].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[2].GetComponent<Renderer>().material = grey;
            coolingSpheres[2].transform.Find("Light").gameObject.SetActive(false);
            coolingSpheres[3].GetComponent<Renderer>().material = grey;
            coolingSpheres[3].transform.Find("Light").gameObject.SetActive(false);
            coolingSpheres[4].GetComponent<Renderer>().material = grey;
            coolingSpheres[4].transform.Find("Light").gameObject.SetActive(false);
        }
        if (logicManager.coolingAmount / logicManager.coolingMaximum < 0.4f && logicManager.coolingAmount / logicManager.coolingMaximum > 0.2f)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = blue;
            coolingSpheres[0].transform.Find("Light").gameObject.SetActive(true);
            coolingSpheres[1].GetComponent<Renderer>().material = grey;
            coolingSpheres[1].transform.Find("Light").gameObject.SetActive(false);
            coolingSpheres[2].GetComponent<Renderer>().material = grey;
            coolingSpheres[2].transform.Find("Light").gameObject.SetActive(false);
            coolingSpheres[3].GetComponent<Renderer>().material = grey;
            coolingSpheres[3].transform.Find("Light").gameObject.SetActive(false);
            coolingSpheres[4].GetComponent<Renderer>().material = grey;
            coolingSpheres[4].transform.Find("Light").gameObject.SetActive(false);
        }
        if (logicManager.coolingAmount / logicManager.coolingMaximum < 0.2f)
        {
            coolingSpheres[0].GetComponent<Renderer>().material = grey;
            coolingSpheres[0].transform.Find("Light").gameObject.SetActive(false);
            coolingSpheres[1].GetComponent<Renderer>().material = grey;
            coolingSpheres[1].transform.Find("Light").gameObject.SetActive(false);
            coolingSpheres[2].GetComponent<Renderer>().material = grey;
            coolingSpheres[2].transform.Find("Light").gameObject.SetActive(false);
            coolingSpheres[3].GetComponent<Renderer>().material = grey;
            coolingSpheres[3].transform.Find("Light").gameObject.SetActive(false);
            coolingSpheres[4].GetComponent<Renderer>().material = grey;
            coolingSpheres[4].transform.Find("Light").gameObject.SetActive(false);
        }







    }
}
