using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraTurning : MonoBehaviour
{

    public bool rotate = false;


    float minAngle = -90.0f;
    float maxAngle = 90.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rotate = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            minAngle = 90;
            maxAngle = 0;
            rotate = true;
        }
        if (rotate == true)
        {
            float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time/3f);
            transform.eulerAngles = new Vector3(0, angle, 0);
            if(angle == maxAngle)
            {
                rotate = false;
            }
        }
    }

























    //public Transform[] views;
    //public float transitionSpeed;
    //Transform currentView;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    currentView = views[0];
    //}

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.R))
    //    {
    //        currentView = views[0];
    //    }
    //    if (Input.GetKeyDown(KeyCode.Q))
    //    {
    //        currentView = views[1];
    //    }
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        currentView = views[2];
    //    }
    //}

    //// Update is called once per frame
    //void LateUpdate()
    //{

    //    transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

    //    Vector3 currentAngle = new Vector3(
    //        Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
    //        Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
    //        Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed)
    //        );

    //    //transform.eulerAngles = currentAngle;

    //}
}
