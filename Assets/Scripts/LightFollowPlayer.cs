using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollowPlayer : MonoBehaviour
{

    public GameObject player;
    public Transform playerTransform;

    void Start()
    {
        player = GameObject.Find("Player");
        playerTransform = player.transform;
    }

    void Update()
    {
        //Licht verfolgt dem spieler
        this.transform.LookAt(playerTransform);
    }
}
