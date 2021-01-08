using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{

    public PlayerController playerController;
    public LookAtMouse lookAtMouse;
    public GameObject player;
    public Rigidbody playerRb;
    public GameObject mainCamera;
    public GameObject mainLight;
    public LabyrinthManager labyrinthManager;


    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        lookAtMouse = GameObject.Find("Player").GetComponent<LookAtMouse>();
        labyrinthManager = GameObject.Find("LabyrinthManager").GetComponent<LabyrinthManager>();
        player = GameObject.Find("Player");
        playerRb = GameObject.Find("Player").GetComponent<Rigidbody>();
        mainCamera = GameObject.Find("MainCamera");
        mainLight = GameObject.Find("MainLight");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SwitchSides(Collider other)
    {

        if(other.tag == "SlopeOneTwo")
        {
            mainCamera.transform.Rotate(0, -90, 0);
            mainLight.transform.Rotate(0, -90, 0);

            player.transform.Rotate(0, 0, -90);
            player.transform.position = new Vector3(-14, 20, 10);

            playerController.moveLeft = new Vector3(0, 0, -1);
            playerController.moveRight = new Vector3(0, 0, 1);

            lookAtMouse.cubeSide = 2;

            lookAtMouse.cameraDirecton = new Vector3(1, 0, 0);

            labyrinthManager.SpawnLabyrinth();
        }

        if (other.tag == "SlopeTwoOne")
        {
            mainCamera.transform.Rotate(0, 90, 0);
            mainLight.transform.Rotate(0, 90, 0);

            player.transform.Rotate(0, 0, 90);
            player.transform.position = new Vector3(-10, 20, 14);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;

            lookAtMouse.cubeSide = 1;

            lookAtMouse.cameraDirecton = new Vector3(0, 0, 1);

            labyrinthManager.DespawnLabyrinth();
        }


        if (other.tag == "SlopeOneThree")
        {
            mainCamera.transform.Rotate(0, 90, 0);
            mainLight.transform.Rotate(0, 90, 0);

            player.transform.Rotate(0, 0, 90);
            player.transform.position = new Vector3(14, 20, 10);

            playerController.moveLeft = new Vector3(0, 0, 1);
            playerController.moveRight = new Vector3(0, 0, -1);

            lookAtMouse.cubeSide = 3;

            lookAtMouse.cameraDirecton = new Vector3(1, 0, 0);
        }

        if (other.tag == "SlopeThreeOne")
        {
            mainCamera.transform.Rotate(0, -90, 0);
            mainLight.transform.Rotate(0, -90, 0);

            player.transform.Rotate(0, 0, -90);
            player.transform.position = new Vector3(10, 20, 14);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;

            lookAtMouse.cubeSide = 1;

            lookAtMouse.cameraDirecton = new Vector3(0, 0, 1);
        }


        if (other.tag == "SlopeOneFour")
        {

            mainLight.transform.position = new Vector3(mainLight.transform.position.x, 70, mainLight.transform.position.z);

            player.transform.position = new Vector3(0, 86, 14);

            lookAtMouse.cubeSide = 1;

        }


        if (other.tag == "SlopeFourOne")
        {

            mainLight.transform.position = new Vector3(mainLight.transform.position.x, 20, mainLight.transform.position.z);

            player.transform.position = new Vector3(0, 8, 14);

            lookAtMouse.cubeSide = 1;

        }

    }
}
