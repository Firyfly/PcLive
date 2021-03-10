using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreation : MonoBehaviour
{

    public int iceCount = 0;
    public int rand;
    public GameObject iceBlock;
    public GameObject[] blockArray;
    public bool spawned = false;

    public float time = 10;
    public int timeMax = 10;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnIce", 0.0f, 10.0f);
        blockArray = new GameObject[5];
    }

    // Update is called once per frame
    void Update()
    {

        time -= Time.deltaTime;
        if(time <= 0)
        {
            SpawnIce();
            time = timeMax;
        }


    }


    public void SpawnIce()
    {

        for (int i = 0; i <= 4; i++)
        {
            if (spawned == false)
            {

                if (blockArray[i] == null)
                {

                    Debug.Log("i");
                    if (iceCount < 5)
                    {
                     
                        blockArray[i] = Instantiate(iceBlock, new Vector3(14.5f, 19+i, -12.5f), new Quaternion(0, 0, 0, 0));
                        iceCount++;
                        spawned = true;
                    }
                }
            }
        }
        spawned = false;
    }

}
