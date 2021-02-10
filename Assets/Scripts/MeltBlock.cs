using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeltBlock : MonoBehaviour
{

    public GameObject parent;
    public bool onTrigger = false;
    public float shrinkRate = -1f;
    public PickUp pickup;
    public IceCreation iceCreation;
    public LogicManager logicManager;
    public Transform cooler;
    private GameObject coolerObject;
    public GameObject child;
    public bool isParent = false;

    // Start is called before the first frame update
    void Start()
    {
        pickup = this.GetComponent<PickUp>();
        iceCreation = GameObject.Find("IceGenerator").GetComponent<IceCreation>();
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();
        coolerObject = GameObject.Find("Cylinder");
        cooler = coolerObject.transform;  
    }

    // Update is called once per frame
    void Update()
    {

        if (onTrigger == true && pickup.hold == false)
        {

            this.transform.localScale += new Vector3(0.07f, 0.01f, 0.01f) * shrinkRate * Time.deltaTime;

            if(isParent == false)
            {
                child.transform.SetParent(cooler);
                isParent = true;
            }

        }

        if(this.transform.localScale.x < 0.2) //this.transform.localScale.x < 0.2 || this.transform.localScale.y < 0.2 || 
        {
            Destroy(parent);
            iceCreation.iceCount -= 1;
            logicManager.AddCooling();
            Debug.Log("Was destroyed");
            logicManager.DecreaseEnergySlightly();
        }

    }

    public void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Cooler")
        {
            onTrigger = true;
        }


    }

    public void OnTriggerExit(Collider other)
    {

        if (other.tag == "Cooler")
        {
            onTrigger = false;
        }



    }





}
