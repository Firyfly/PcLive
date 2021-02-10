using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    public GameObject parent;
    public bool onConveyor = false;
    public bool onConveyorEnd = false;
    public PickUp pickup;
    public BlockCreation blockCreation1;
    public BlockCreation blockCreation0;
    public LogicManager logicManager;
    public BinaryManager binaryManager;

    public bool destroying = false;

    public float blockDestroyTime;

    // Start is called before the first frame update
    void Start()
    {
        pickup = this.GetComponent<PickUp>();
        blockCreation0 = GameObject.Find("BlockGenerator0").GetComponent<BlockCreation>();
        blockCreation1 = GameObject.Find("BlockGenerator1").GetComponent<BlockCreation>();
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();
        binaryManager = GameObject.Find("BinaryManager").GetComponent<BinaryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        blockDestroyTime = binaryManager.cpuDestroyBlockTime;
        if(onConveyor == true && pickup.hold == false)
        {

            this.GetComponent<Rigidbody>().AddForce(0, 1, 0, ForceMode.Force);

        }
        if(onConveyorEnd == true)
        {
           
            if (logicManager.coolingAmount > 1 && logicManager.energyAmount > 1) {
                if (destroying == false)
                {
                    Invoke("DestroyBlock", blockDestroyTime);
                   
                    destroying = true;
                }

            }
        }


        //If bool convey true and hold(this.getcomponent.pickup) is false
        //Then test rigidbody constant force


    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ConveyorEnd")
        {

            onConveyorEnd = true;
            

        }
       

        if (other.tag == "Conveyor")
        {
      
            onConveyor = true;

        }
        




    }

    public void OnTriggerExit(Collider other)
    {

        if (other.tag == "Conveyor")
        {

            onConveyor = false;

        }



    }



    public void DestroyBlock()
    {
        if(parent.tag == "Block1")
        {
            binaryManager.BlockCheck(1);
            blockCreation1.objectCount -= 1;
        }
        else
        {
            binaryManager.BlockCheck(0);
            blockCreation0.objectCount -= 1;
        }

        Destroy(parent);
        logicManager.DecreaseCooling();
        logicManager.DecreaseEnergy();
        destroying = false;
    }











    //On trigger enter, set bool true das convey nach oben, other.tag conveyor
    //when der trigger conveyorEnd ist, dann destroy after 5 seconds, das dauert, durch collision kommen nicht alle hinternander dann dran


    //On trigger exit, set this bool false



}
