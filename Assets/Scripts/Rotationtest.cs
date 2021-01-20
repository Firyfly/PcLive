using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationtest : MonoBehaviour
{

    float minAngle = 0.0f;
    float maxAngle = 45.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
