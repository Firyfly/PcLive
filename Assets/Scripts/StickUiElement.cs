using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StickUiElement : MonoBehaviour
{

    public GameObject ui;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 positionUI = Camera.main.WorldToScreenPoint(this.transform.position);

        ui.transform.position = positionUI;


    }
}
