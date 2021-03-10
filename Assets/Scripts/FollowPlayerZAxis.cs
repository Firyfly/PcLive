using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerZAxis : MonoBehaviour
{

    private GameObject player;
    public Transform playerTransform;
    public bool enter = false;
    public bool exit = false;
    public bool upwards = false;

    public bool lookingAtMouse = false;
    public bool lookingAtPlayer = true;


    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float yaw = 0.0f;
    public float pitch = 0.0f;

    public LookAtMouse lookAtMouse;

    public bool horizontal = true;
    public bool vertical = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerTransform = player.transform;
        lookAtMouse = GameObject.Find("Player").GetComponent<LookAtMouse>();
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.LookAt(playerTransform);

        //if (player.transform.position.y > 28 && once == false && player.transform.position.z > 13.7 && player.transform.position.y <= 50)
        //{
        //    transform.Rotate(-20, 0, 0);
        //    once = true;
        //}
        //if (player.transform.position.y < 28 && once == true && player.transform.position.z > 13.7)
        //{
        //    transform.Rotate(20, 0, 0);
        //    once = false;
        //}

        if (lookAtMouse.cubeSide == 1 || lookAtMouse.cubeSide == 2 || lookAtMouse.cubeSide == 3)
        {
            //if(horizontal == false)
            //{
            //    transform.position = new Vector3(0, player.transform.position.y, 0);
            //    horizontal = true;
            //}
            transform.position = new Vector3(0, player.transform.position.y, 0);
        }
        if (lookAtMouse.cubeSide == 4 || lookAtMouse.cubeSide == 4)
        {
            transform.position = new Vector3(0, 25, player.transform.position.z);
        }



        //if (enter == true)
        //{
           
        //    if (upwards == false)
        //    {
        //        transform.Rotate(-35, 0, 0);
        //        enter = false;
        //    }
        //    upwards = true;
        //}
        //if (exit == true)
        //{
        //    if (upwards == true)
        //    {
        //        if (transform.rotation.x != 0)
        //        {
        //            transform.Rotate(35, 0, 0);
        //            exit = false;
        //        }
        //    }
        //    upwards = false;
        //}


        if (Input.GetKeyDown(KeyCode.R))
        {
            lookingAtMouse = true;
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            lookingAtMouse = false;
        }

        if (lookingAtMouse == true)
        {

            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            lookingAtPlayer = false;
        }
        else
        {
            if (lookingAtPlayer == false)
            {
                if (lookAtMouse.cubeSide == 1)
                {
                    this.transform.rotation = new Quaternion(0, 0, 0, 0);
                }
                if (lookAtMouse.cubeSide == 2)
                {
                    this.transform.rotation = new Quaternion(0, -0.5f, 0, 0.5f);
                }
                if (lookAtMouse.cubeSide == 3)
                {
                    this.transform.rotation = new Quaternion(0, 0.5f, 0, 0.5f);
                }
                if (lookAtMouse.cubeSide == 4)
                {
                    this.transform.rotation = new Quaternion(0.5f, 0, 0, 0.5f);
                }
                if (lookAtMouse.cubeSide == 5)
                {
                    this.transform.rotation = new Quaternion(-0.5f, 0, 0, 0.5f);
                }


                if (lookAtMouse.cubeSide == 1 || lookAtMouse.cubeSide == 2 || lookAtMouse.cubeSide == 3)
                {
                    transform.position = new Vector3(0, player.transform.position.y, 0);
                }
                if (lookAtMouse.cubeSide == 4 || lookAtMouse.cubeSide == 4)
                {
                    transform.position = new Vector3(0, 25, player.transform.position.z);
                }


                lookingAtPlayer = true;
            }
        }
        
    }
}
