using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{

    private int showCoins;
    public Text coinsText;
    public CoinManager coinManager;

    // Start is called before the first frame update
    void Start()
    {
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
    }

    // Update is called once per frame
    void Update()
    {
        showCoins = Mathf.RoundToInt(coinManager.coins);

        coinsText.text = "Coins: " + showCoins;

    }
}
