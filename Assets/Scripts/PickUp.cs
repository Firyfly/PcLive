using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform holdDestination;
    public bool hold = false;
    public MeltBlock meltBlock;


    // Start is called before the first frame update
    void Start()
    {
        holdDestination = GameObject.Find("Player").transform.Find("HoldDestination");
        meltBlock = this.GetComponent<MeltBlock>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (meltBlock.onTrigger == true)
        {
            meltBlock.onTrigger = false;
            meltBlock.child.transform.parent = null;
            meltBlock.isParent = false;
        }

        this.transform.position = holdDestination.position;
        this.transform.parent = GameObject.Find("HoldDestination").transform;
        hold = true;


    }

    void OnMouseUp()
    {

        hold = false;
        this.transform.parent = null;

    }



}
