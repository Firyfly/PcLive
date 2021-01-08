using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public float coins = 2;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            coins++;
        }


        //Debug.Log(coins);
    }

    public void CoinsAdd(float coinCount)
    {
        coins += coinCount;
    }

    public void CoinsSub(float coinCount)
    {
        coins -= coinCount;
    }
}
