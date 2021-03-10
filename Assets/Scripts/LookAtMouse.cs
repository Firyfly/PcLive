using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{

    public GameObject player;
    public Vector3 cameraDirecton = Vector3.forward;
    public float cubeSide = 1;
    public Vector3 mouseWorld;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

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

        Vector3 forward = mouseWorld - player.transform.position;
        player.transform.rotation = Quaternion.LookRotation(forward, cameraDirecton);




        //Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //float midPoint = (transform.position - Camera.main.transform.position).magnitude * 0.5f;

        //transform.LookAt(mouseRay.origin + mouseRay.direction * midPoint);


        //var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        //var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


    }
}
