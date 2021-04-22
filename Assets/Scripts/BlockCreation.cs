using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreation : MonoBehaviour
{

    private int rand1,rand2;
    public GameObject[] blocks;
    public GameObject[] blockArray;
    public int objectCount = 0;
    public bool spawned = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 0.0f, 5.0f);
        blockArray = new GameObject[5];
    }

    // Update is called once per frame
    void Update()
    {


    
    }


    public void SpawnObject()
    {
        //Spawnt Blöcke für die erste Maschine
        if (transform.position.x < 0)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (spawned == false)
                {
                    if (blockArray[i] == null)
                    {
                        if (objectCount < 5)
                        {
                            blockArray[i] = Instantiate(blocks[0], new Vector3(-12 + i+1, 8, 14.5f), new Quaternion(0, 0, 0, 0));
                            objectCount++;
                            spawned = true;

                        }
                    }
                }

            }
        }//Spawnt Blöcke für die zweite Maschine
        if (transform.position.x > 0)
        {
           
            for (int i = 0; i <= 4; i++)
            {
                if (spawned == false)
                {
                   
                    if (blockArray[i] == null)
                    {
                      
                        if (objectCount < 5)
                        {
                     
                            blockArray[i] = Instantiate(blocks[0], new Vector3(6 + i+1, 8, 14.5f), new Quaternion(0, 0, 0, 0));
                            objectCount++;
                            spawned = true;
                        }
                    }
                }

            }
        }

        spawned = false;

    }
}
