using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreation : MonoBehaviour
{
    public GameObject iceBlock;
    public GameObject[] blockArray;

    public int iceCount = 0;
    public int rand;
    public bool spawned = false;

    public float time = 10;
    public int timeMax = 10;

    void Start()
    {
        blockArray = new GameObject[5];
    }


    void Update()
    {
        //Rufe die Spawn Funktion nach einem Timer auf
        time -= Time.deltaTime;
        if(time <= 0)
        {
            SpawnIce();
            time = timeMax;
        }
    }

    //Spawnt Eisblöcke so lange die maximale Anzahl noch nicht erreicht ist
    public void SpawnIce()
    {
        for (int i = 0; i <= 4; i++)
        {
            if (spawned == false)
            {
                if (blockArray[i] == null)
                {
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
