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

    public bool horizontal = true;
    public bool vertical = true;

    public bool lookingAtMouse = false;
    public bool lookingAtPlayer = true;

    public float speedH = 2.0f;
    public float speedV = 2.0f;
    public float yaw = 0.0f;
    public float pitch = 0.0f;

    public LookAtMouse lookAtMouse;

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
        //Ändert den Vector abhängig von der Seite
        if (lookAtMouse.cubeSide == 1 || lookAtMouse.cubeSide == 2 || lookAtMouse.cubeSide == 3)
        {
            transform.position = new Vector3(0, player.transform.position.y, 0);
        }
        if (lookAtMouse.cubeSide == 4 || lookAtMouse.cubeSide == 5)
        {
            transform.position = new Vector3(0, 22, player.transform.position.z);
        }

        //Überprüft ob R gepresst ist und damit der Free-Look Modus aktiv ist
        if (Input.GetKeyDown(KeyCode.R))
        {
            lookingAtMouse = true;
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            lookingAtMouse = false;
        }

        //Free-Look Modus
        if (lookingAtMouse == true)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            lookingAtPlayer = false;
        }
        else
        {//Falls kein Free-Look Modus aktiv ist, Kamera an die passende rotierung rotieren
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

                //Wie mit der Rotation, sicher stellen das die kamera an der richtigen Stelle ist
                if (lookAtMouse.cubeSide == 1 || lookAtMouse.cubeSide == 2 || lookAtMouse.cubeSide == 3)
                {
                    transform.position = new Vector3(0, player.transform.position.y, 0);
                }
                if (lookAtMouse.cubeSide == 4 || lookAtMouse.cubeSide == 5)
                {
                    transform.position = new Vector3(0, 22, player.transform.position.z);
                }


                lookingAtPlayer = true;
            }
        }
        
    }
}
