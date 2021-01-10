using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollowPlayer : MonoBehaviour
{

    public GameObject player;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerTransform = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(playerTransform);
    }
}
