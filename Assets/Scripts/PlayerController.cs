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


    public Vector3 moveUp;
    public Vector3 moveDown;
    public Vector3 moveLeft;
    public Vector3 moveRight;

    // Start is called before the first frame update
    void Start()
    {
       cubeManager = GameObject.Find("CubeManager").GetComponent<CubeManager>();
        labyrinthManager = GameObject.Find("LabyrinthManager").GetComponent<LabyrinthManager>();


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

    }


}
