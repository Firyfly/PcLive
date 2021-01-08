using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform holdDestination;
    public bool hold = false;


    // Start is called before the first frame update
    void Start()
    {
        holdDestination = GameObject.Find("Player").transform.Find("HoldDestination");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {

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
