using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{

    public GameObject player;

    public Vector3 cameraDirecton = Vector3.forward;
    public Vector3 mouseWorld;

    public float cubeSide = 1;
    public bool vertical = false;



   
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        //Passt den Vector abhängig von der Seite auf welcher der Spieler ist an
        Vector3 mouse = Input.mousePosition;
        if (cubeSide == 1)
        {
            mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(
                                                                mouse.x,
                                                                mouse.y,
                                                                 player.transform.position.z));
        }
        if (cubeSide == 2)
        {
            mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(
                                                                mouse.x,
                                                                mouse.y,
                                                                 -player.transform.position.x));
        }
        if (cubeSide == 3)
        {
            mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(
                                                                mouse.x,
                                                                mouse.y,
                                                                 player.transform.position.x));
        }
        if (cubeSide == 4)
        {
            mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(
                                                                mouse.x,
                                                                mouse.y,
                                                                 Camera.main.nearClipPlane));
        }
        if (cubeSide == 5)
        {
            mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(
                                                                mouse.x,
                                                                mouse.y,
                                                                 player.transform.position.z));
        }

        //Setzt die Rotierung auf den Spieler um
        Vector3 forward = mouseWorld - player.transform.position;
        player.transform.rotation = Quaternion.LookRotation(forward, cameraDirecton);

    }
}
