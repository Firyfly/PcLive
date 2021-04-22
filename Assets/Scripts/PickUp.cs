using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform holdDestination;

    public bool hold = false;

    public MeltBlock meltBlock;
    public SoundManager soundManager;

    void Start()
    {
        holdDestination = GameObject.Find("Player").transform.Find("HoldDestination");
        if (this.tag == "Ice")
        {
            meltBlock = this.GetComponent<MeltBlock>();
        }
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        //Wenn Spieler auf das Eis klickt, dann wird dies zum Kind des Spielercharakters
        if (this.tag == "Ice")
        {
            if (meltBlock.onTrigger == true)
            {
                meltBlock.onTrigger = false;
                meltBlock.child.transform.parent = null;
                meltBlock.isParent = false;
            }
        }

        //Bringt das Eis zur "HoldPosition" beim Spielercharakter
        this.transform.position = holdDestination.position;
        this.transform.parent = GameObject.Find("HoldDestination").transform;
        hold = true;

        soundManager.PlayBoxPickUp();

    }

    void OnMouseUp()
    {
        //Lässt der Spieler los, dann wird der Spielercharakter als Elternobjekt gelöscht
        hold = false;
        this.transform.parent = null;

        soundManager.PlayDropBox();

    }



}
