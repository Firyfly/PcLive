using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{

    public LogicManager logicManager;

    public Text energyText;
    public Text coolingText;

    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {

        energyText.text = logicManager.energyAmount + " / " + logicManager.energyMaximum;
        coolingText.text = logicManager.coolingAmount + " / " + logicManager.coolingMaximum;
    }
}
