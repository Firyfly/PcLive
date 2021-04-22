using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    public GameObject parent;
    public bool onConveyor = false;
    public bool onConveyorEnd = false;
    public bool destroying = false;

    public float blockDestroyTime;
    public float blockResetTime = 30;

    public PickUp pickup;
    public LogicManager logicManager;
    public BinaryManager binaryManager;
    public BlockCreation blockCreation1;
    public BlockCreation blockCreation0;


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
        if(onConveyor == true && pickup.hold == false)//Wenn Block auf dem Laufband, bewege es nach oben
        {

            this.GetComponent<Rigidbody>().AddForce(0, 1, 0, ForceMode.Force);

        }
        if(onConveyorEnd == true)//Wenn Block am Ende vom Laufband, höre auf ihn zu bewegen und zerstöre ihn 
        {
           
            if (logicManager.coolingAmount > 20 && logicManager.energyAmount > 15) {
                if (destroying == false)
                {
                    Invoke("DestroyBlock", blockDestroyTime);
                   
                    destroying = true;
                }

            }
        }

        //Timer fürs zerstören von Blöcken
        if (blockResetTime >= 0)
        {
            blockResetTime -= Time.deltaTime;
        }
        else
        {
            Destroy(parent);
        }

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
        //Übergebe den 0 oder 1 wert an den BinaryManager
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

        //Zieht Energie und Kühlung ab
        Destroy(parent);
        logicManager.DecreaseCooling();
        logicManager.DecreaseEnergy();
        destroying = false;
    }














}
