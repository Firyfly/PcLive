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

    private void Start()
    {
        
    }

    void Update()
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




        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    minAngle = 0.0f;
        //    maxAngle = 90.0f;
        //    rotating = true;
        //}
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    minAngle = 40;
        //    maxAngle = -90f;
        //    rotating = true;
        //}
        //if (rotating == true)
        //{
        //    float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time/1.5f);
        //    transform.eulerAngles = new Vector3(0, angle, 0);
        //    if(angle == maxAngle)
        //    {
        //        rotating = false;
        //    }
        //}
    }


    //public void TurnSmooth(float min, float max)
    //{
    //    if (rotating == true)
    //    {
    //        StartCoroutine(TurnNow(min, max));
    //    }
    //}

    //IEnumerator TurnNow(float min,float max)
    //{
    //    do {
    //        angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time / 1.5f);
    //        transform.eulerAngles = new Vector3(0, angle, 0);
    //        if (angle == maxAngle)
    //        {
    //            rotating = false;
    //        }
    //    } while(angle == maxAngle || counter);

    //    yield return null;
    //}




















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
