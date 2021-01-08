using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreation : MonoBehaviour
{

    public int iceCount = 0;
    public int rand;
    public GameObject iceBlock;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnIce", 0.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnIce()
    {
        if (iceCount <= 5)
        {

                rand = Random.Range(19, 23);
                Instantiate(iceBlock, new Vector3(14.5f, rand, -12.5f), new Quaternion(0, 0, 0, 0));
                iceCount++;
            
        }
    }

}
