using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public float coins;



    // Start is called before the first frame update
    void Start()
    {
        //Schauen ob Bitcoins vorhanden sind, wenn keine vorhanden sind oder es 0 ist, dann wird die Anzahl aus den Playerprefs genommen
        if(PlayerPrefs.GetFloat("Coins") == 0)
        {
            coins = 0;
        }
        else
        {
            coins = PlayerPrefs.GetFloat("Coins");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CoinsAdd(float coinCount)
    {
        //Hinzufügen von Bitcoins und das speichern im Playerpref
        coins += coinCount;
        PlayerPrefs.SetFloat("Coins", coins);
    }

    public void CoinsSub(float coinCount)
    {
        //Abziehen von Bitcoins und das speichern im Playerpref
        coins -= coinCount;
        PlayerPrefs.SetFloat("Coins", coins);
    }
}
