using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    void Start()
    {
        
    }
    //Dreht das Objekt
    void Update()
    {
        transform.Rotate(0, 0.15f, 0);
    }
}
