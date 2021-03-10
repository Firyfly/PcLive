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

    public SmoothCameraTurning smoothCameraTurning;





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
        smoothCameraTurning = mainCamera.GetComponent<SmoothCameraTurning>();
        
    }

    // Update is called once per frame
    void Update()
    {


    }


    public void SwitchSides(Collider other)
    {

        if(other.tag == "SlopeOneTwo")
        {
            
            smoothCameraTurning.minAngle = 0;
            smoothCameraTurning.maxAngle = -90;
            lookAtMouse.cubeSide = 2;
            smoothCameraTurning.rotating = true;



            mainLight.transform.Rotate(0, -90, 0);

            player.transform.Rotate(0, 0, -90);
            player.transform.position = new Vector3(-14, 20, 10);

            playerController.moveLeft = new Vector3(0, 0, -1);
            playerController.moveRight = new Vector3(0, 0, 1);

            

            lookAtMouse.cameraDirecton = new Vector3(1, 0, 0);

            labyrinthManager.SpawnLabyrinth();
        }

        if (other.tag == "SlopeTwoOne")
        {

            smoothCameraTurning.minAngle = -90;
            smoothCameraTurning.maxAngle = 0;
            lookAtMouse.cubeSide = 1;
            smoothCameraTurning.rotating = true;



            mainLight.transform.Rotate(0, 90, 0);

            player.transform.Rotate(0, 0, 90);
            player.transform.position = new Vector3(-10, 20, 14);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;

           

            lookAtMouse.cameraDirecton = new Vector3(0, 0, 1);

            labyrinthManager.DespawnLabyrinth();
        }


        if (other.tag == "SlopeOneThree")
        {
            smoothCameraTurning.minAngle = 0;
            smoothCameraTurning.maxAngle = 90;
            lookAtMouse.cubeSide = 3;
            smoothCameraTurning.rotating = true;




            mainLight.transform.Rotate(0, 90, 0);

            player.transform.Rotate(0, 0, 90);
            player.transform.position = new Vector3(14, 20, 10);

            playerController.moveLeft = new Vector3(0, 0, 1);
            playerController.moveRight = new Vector3(0, 0, -1);

           

            lookAtMouse.cameraDirecton = new Vector3(1, 0, 0);
        }

        if (other.tag == "SlopeThreeOne")
        {
            smoothCameraTurning.minAngle = 90;
            smoothCameraTurning.maxAngle = 0;
            lookAtMouse.cubeSide = 1;
            smoothCameraTurning.rotating = true;




            mainLight.transform.Rotate(0, -90, 0);

            player.transform.Rotate(0, 0, -90);
            player.transform.position = new Vector3(10, 20, 14);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;

           

            lookAtMouse.cameraDirecton = new Vector3(0, 0, 1);
        }










        if (other.tag == "SlopeOneFour")
        {
            smoothCameraTurning.minAngle = 0;
            smoothCameraTurning.maxAngle = 90;
            lookAtMouse.cubeSide = 4;
            smoothCameraTurning.rotating = true;

            mainLight.transform.Rotate(90, 0, 0);

            player.transform.position = new Vector3(0, 6, 10);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;
            playerController.moveUp = Vector3.forward;
            playerController.moveDown = -Vector3.forward;

            lookAtMouse.cameraDirecton = new Vector3(0, 0, -1);
        }


        if (other.tag == "SlopeFourOne")
        {
            smoothCameraTurning.minAngle = 0;
            smoothCameraTurning.maxAngle = 90;
            lookAtMouse.cubeSide = 1;
            smoothCameraTurning.rotating = true;

            mainLight.transform.Rotate(-90, 0, 0);

            player.transform.position = new Vector3(0, 7.5f, 14);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;
            

            lookAtMouse.cameraDirecton = new Vector3(0, 0, 1);
        }






        if (other.tag == "SlopeOneFive")
        {



        }


        if (other.tag == "SlopeFiveOne")
        {



        }

    }
}
