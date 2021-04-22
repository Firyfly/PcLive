using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{

  
    public GameObject player;
    public Rigidbody playerRb;
    public GameObject mainCamera;
    public GameObject mainLight;
    public Light mainLightPointLight;
    public GameObject mainLightPointObject;

    public float lightIntensity = 0.5f;

    public LabyrinthManager labyrinthManager;
    public PlayerController playerController;
    public LookAtMouse lookAtMouse;
    public SmoothCameraTurning smoothCameraTurning;
    public SoundManager soundManager;

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
        mainLightPointObject = GameObject.Find("MainLightPoint");
        mainLightPointLight = mainLightPointObject.GetComponent<Light>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

        lightIntensity = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        mainLightPointLight.intensity = lightIntensity;
    }

    //Funktion welche die Betroffenen Objekte bewegt/rotiert beim wechsel einer Seite, und welche die betroffenen Variblen anpasst
    public void SwitchSides(Collider other)
    {

        //Seite 2 und 1
        if (other.tag == "SlopeOneTwo")
        {
            smoothCameraTurning.minAngle = 0;
            smoothCameraTurning.maxAngle = -90;
            lookAtMouse.cubeSide = 2;
            lookAtMouse.vertical = false;
            smoothCameraTurning.rotating = true;

            player.transform.Rotate(0, 0, -90);
            player.transform.position = new Vector3(-14, 20, 10);

            playerController.moveLeft = new Vector3(0, 0, -1);
            playerController.moveRight = new Vector3(0, 0, 1);


            lookAtMouse.cameraDirecton = new Vector3(1, 0, 0);
            labyrinthManager.SpawnLabyrinth();
            soundManager.PlaySwitch();
        }
        if (other.tag == "SlopeTwoOne")
        {
            smoothCameraTurning.minAngle = -90;
            smoothCameraTurning.maxAngle = 0;
            lookAtMouse.cubeSide = 1;
            lookAtMouse.vertical = false;
            smoothCameraTurning.rotating = true;

            player.transform.Rotate(0, 0, 90);
            player.transform.position = new Vector3(-10, 20, 14);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;

            lookAtMouse.cameraDirecton = new Vector3(0, 0, 1);
            labyrinthManager.DespawnLabyrinth();
            soundManager.PlaySwitch();
        }

        //Seite 3 und 1
        if (other.tag == "SlopeOneThree")
        {
            smoothCameraTurning.minAngle = 0;
            smoothCameraTurning.maxAngle = 90;
            lookAtMouse.cubeSide = 3;
            lookAtMouse.vertical = false;
            smoothCameraTurning.rotating = true;

            player.transform.Rotate(0, 0, 90);
            player.transform.position = new Vector3(14, 20, 10);

            playerController.moveLeft = new Vector3(0, 0, 1);
            playerController.moveRight = new Vector3(0, 0, -1);

            lookAtMouse.cameraDirecton = new Vector3(1, 0, 0);
            soundManager.PlaySwitch();
        }
        if (other.tag == "SlopeThreeOne")
        {
            smoothCameraTurning.minAngle = 90;
            smoothCameraTurning.maxAngle = 0;
            lookAtMouse.cubeSide = 1;
            lookAtMouse.vertical = false;
            smoothCameraTurning.rotating = true;

            player.transform.Rotate(0, 0, -90);
            player.transform.position = new Vector3(10, 20, 14);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;

            lookAtMouse.cameraDirecton = new Vector3(0, 0, 1);
            soundManager.PlaySwitch();
        }

        //Seite 4 und 1
        if (other.tag == "SlopeOneFour")
        {
            smoothCameraTurning.minAngle = 0;
            smoothCameraTurning.maxAngle = 90;
            lookAtMouse.cubeSide = 4;
            lookAtMouse.vertical = true;
            smoothCameraTurning.rotating = true;

            player.transform.position = new Vector3(0, 6, 10);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;
            playerController.moveUp = Vector3.forward;
            playerController.moveDown = -Vector3.forward;

            lookAtMouse.cameraDirecton = new Vector3(0, 0, -1);
            soundManager.PlaySwitch();
        }

        if (other.tag == "SlopeFourOne")
        {
            smoothCameraTurning.minAngle = 90;
            smoothCameraTurning.maxAngle = 0;
            lookAtMouse.cubeSide = 1;
            lookAtMouse.vertical = true;
            smoothCameraTurning.rotating = true;

            player.transform.position = new Vector3(0, 7.5f, 14);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;
            playerController.moveUp = Vector3.up;
            playerController.moveDown = Vector3.down;

            lookAtMouse.cameraDirecton = new Vector3(0, 0, 1);
            soundManager.PlaySwitch();

        }

        //Seite 5 und 1
        if (other.tag == "SlopeOneFive")
        {
            smoothCameraTurning.minAngle = 0;
            smoothCameraTurning.maxAngle = -90;
            lookAtMouse.cubeSide = 5;
            lookAtMouse.vertical = true;
            smoothCameraTurning.rotating = true;

            player.transform.position = new Vector3(0, 34, 10);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;
            playerController.moveUp = -Vector3.forward;
            playerController.moveDown = Vector3.forward;

            lookAtMouse.cameraDirecton = new Vector3(0, 0, -1);
            soundManager.PlaySwitch();


        }
        if (other.tag == "SlopeFiveOne")
        {
            smoothCameraTurning.minAngle = -90;
            smoothCameraTurning.maxAngle = 0;
            lookAtMouse.cubeSide = 1;
            lookAtMouse.vertical = true;
            smoothCameraTurning.rotating = true;

            player.transform.position = new Vector3(0, 30, 14);

            playerController.moveLeft = Vector3.left;
            playerController.moveRight = Vector3.right;
            playerController.moveUp = Vector3.up;
            playerController.moveDown = Vector3.down;

            lookAtMouse.cameraDirecton = new Vector3(0, 0, -1);
            soundManager.PlaySwitch();
        }

    }
}
