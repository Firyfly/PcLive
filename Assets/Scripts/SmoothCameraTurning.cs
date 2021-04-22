using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraTurning : MonoBehaviour
{

    public bool rotating = false;

    public float minAngle = 0;
    public float maxAngle = 0;

    public float lerpTime = 1.2f;
    static float t = 0.0f;

    public LookAtMouse lookAtMouse;

    private void Start()
    {
        lookAtMouse = GameObject.Find("Player").GetComponent<LookAtMouse>();
    }

    void Update()
    {


        //Interpolierung der Kamera beim wechsel auf horizontaler Ebene
        if (lookAtMouse.vertical == false)
        {
            if (rotating == true)
            {

                float angle = Mathf.LerpAngle(minAngle, maxAngle, t);
                transform.eulerAngles = new Vector3(0, angle, 0);

                t += lerpTime * Time.deltaTime;

                if (t >= 1.0f)
                {
                    rotating = false;
                    t = 0;
                }

            }
        }
        //Interpolierung der Kamera beim wechsel auf vertikaler Ebene
        if (lookAtMouse.vertical == true)
        {
            if (rotating == true)
            {

                float angle = Mathf.LerpAngle(minAngle, maxAngle, t);
                transform.eulerAngles = new Vector3(angle, 0, 0);

                t += lerpTime * Time.deltaTime;


                if (t >= 1.0f)
                {
                    rotating = false;
                    t = 0;
                }



            }
        }
    }
}
