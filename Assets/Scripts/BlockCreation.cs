using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreation : MonoBehaviour
{

    private int rand1,rand2;
    public GameObject[] blocks;
    public int objectCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 0.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {


    
    }


    public void SpawnObject()
    {
        if (objectCount <= 5)
        {
            if (transform.position.x < 0)
            {
                rand2 = Random.Range(-12, -5);
                Instantiate(blocks[0], new Vector3(rand2, 8, 14.5f), new Quaternion(0, 0, 0, 0));
                objectCount++;
            }
            if(transform.position.x > 0)
            {
                rand2 = Random.Range(6, 13);
                Instantiate(blocks[0], new Vector3(rand2, 8, 14.5f), new Quaternion(0, 0, 0, 0));
                objectCount++;
            }
        }
    }
}
