using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed = 100;

    public float playerPositionY;

    public bool triggered = false;

    public CubeManager cubeManager;
    public LabyrinthManager labyrinthManager;
    public FollowPlayerZAxis followPlayerZAxis;

    public Vector3 moveUp;
    public Vector3 moveDown;
    public Vector3 moveLeft;
    public Vector3 moveRight;

    public CPUUpgradeMaschine cpuUpgradeMaschine;

    // Start is called before the first frame update
    void Start()
    {
       cubeManager = GameObject.Find("CubeManager").GetComponent<CubeManager>();
        labyrinthManager = GameObject.Find("LabyrinthManager").GetComponent<LabyrinthManager>();
        followPlayerZAxis = GameObject.Find("MainCamera").GetComponent<FollowPlayerZAxis>();

        cpuUpgradeMaschine = GameObject.Find("CPUUpgradeMaschine").GetComponent<CPUUpgradeMaschine>();


       moveUp = new Vector3(0, 1, 0);
       moveDown = new Vector3(0, -1, 0);
       moveLeft = new Vector3(-1, 0, 0);
       moveRight = new Vector3(1, 0, 0);
    }
    
    // Update is called once per frame
    void Update()
    {
        playerPositionY = transform.position.y;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(moveUp * playerSpeed * Time.deltaTime,Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(moveDown * playerSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(moveLeft * playerSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveRight * playerSpeed * Time.deltaTime, Space.World);
        }



    }

    void OnTriggerEnter(Collider other)
    {

        cubeManager.SwitchSides(other);

        labyrinthManager.InteractLabyrinth(other);

        if (other.tag == "GPUMaschine")
        {
            followPlayerZAxis.enter = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "GPUMaschine")
        {
            followPlayerZAxis.exit = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            if(other.tag == "CPUUpgradeMaschine")
            {
                cpuUpgradeMaschine.CPUUpgrade();
            }


        }



    }


}
