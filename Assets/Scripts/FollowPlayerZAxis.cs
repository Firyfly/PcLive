using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerZAxis : MonoBehaviour
{

    private GameObject player;
    public bool once = false;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if(player.transform.position.y > 28 && once == false && player.transform.position.z > 13.7 && player.transform.position.y <= 50)
        {
            transform.Rotate(-20, 0, 0);
            once = true;
        }
        if (player.transform.position.y < 28 && once == true && player.transform.position.z > 13.7)
        {
            transform.Rotate(20, 0, 0);
            once = false;
        }


        transform.position = new Vector3(0, player.transform.position.y, 0);
    }
}
