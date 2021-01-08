using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeltBlock : MonoBehaviour
{

    public GameObject parent;
    public bool onTrigger = false;
    public float shrinkRate = -2f;
    public PickUp pickup;
    public IceCreation iceCreation;
    public LogicManager logicManager;

    // Start is called before the first frame update
    void Start()
    {
        pickup = this.GetComponent<PickUp>();
        iceCreation = GameObject.Find("IceGenerator").GetComponent<IceCreation>();
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (onTrigger == true && pickup.hold == false)
        {

            this.transform.localScale += new Vector3(0.1F, 0.1f, 0.1f) * shrinkRate * Time.deltaTime;

        }

        if(this.transform.localScale.x < 0.2)
        {
            Destroy(parent);
            iceCreation.iceCount -= 1;
            logicManager.AddCooling();
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
