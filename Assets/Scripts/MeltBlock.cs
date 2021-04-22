using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeltBlock : MonoBehaviour
{

    public GameObject parent;
    public ParticleSystem particles;
    public Transform cooler;
    private GameObject coolerObject;
    public GameObject child;

    public bool onTrigger = false;
    public float shrinkRate = -1f;
    public bool isParent = false;
    public bool once = true;
    public bool meltOnce = false;

    public SoundManager soundManager;
    public IceCreation iceCreation;
    public LogicManager logicManager;
    public PickUp pickup;

    void Start()
    {
        pickup = this.GetComponent<PickUp>();
        iceCreation = GameObject.Find("IceGenerator").GetComponent<IceCreation>();
        logicManager = GameObject.Find("LogicManager").GetComponent<LogicManager>();
        coolerObject = GameObject.Find("Cylinder");
        cooler = coolerObject.transform;
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {
        //Lässt das Eis schmelzen und mach es zum Kind des Coolers
        if (onTrigger == true && pickup.hold == false)
        {
            this.transform.localScale += new Vector3(0.07f, 0.01f, 0.01f) * shrinkRate * Time.deltaTime;
            if(isParent == false)
            {
                child.transform.SetParent(cooler);
                isParent = true;
            }
        }

        //Wenn das Eis klein genug ist, dann wird es Zerstört und alle verbundenen Effekte eingeleitet 
        if(this.transform.localScale.x < 0.2)
        {
            if (!particles.isPlaying)
            {
                particles.Play();
                soundManager.PlayIceMelt();
            }

            if (meltOnce == false)
            {
                iceCreation.iceCount -= 1;
                logicManager.AddCooling();
                logicManager.DecreaseEnergySlightly();
                parent.GetComponent<Renderer>().enabled = false;
                Invoke("DestroyParent", 1);
                meltOnce = true;


            }
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

    public void DestroyParent()
    {
        Destroy(parent);
    }


}
