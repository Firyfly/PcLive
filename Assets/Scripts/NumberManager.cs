using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberManager : MonoBehaviour
{

    public CoinManager coinManager;

    public int stellen;

    public GameObject[] numbers;

    public float coinsOld;

    public GameObject einserBlock;
    public GameObject zehnerBlock;
    public GameObject hunderterBlock;
    public GameObject tausenderBlock;

    public bool start = true;

    // Start is called before the first frame update
    void Start()
    {
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();

        coinsOld = coinManager.coins;
    }

    // Update is called once per frame
    void Update()
    {

        if (coinsOld != coinManager.coins || start == true)
        {
            //int places = Mathf.FloorToInt(coinManager.coins/10);
            float places = coinManager.coins / 10;

            if (places < 1)
            {
                //1 Stelle 0-9
                stellen = 1;
                int einer = (int)coinManager.coins;
                EinerStelle(einer);

            }
            else if (places >= 1 && places < 10)
            {
                //2 Stellen 10-99
                stellen = 2;

                int zehner = Mathf.FloorToInt(coinManager.coins / 10);
                ZehnerStelle(zehner);
                int einer = (int)coinManager.coins - zehner * 10;
                EinerStelle(einer);

            }
            else if (places >= 10 && places < 100)
            {
                //3 Stellen 100-999
                stellen = 3;
                int hunderter = Mathf.FloorToInt(coinManager.coins / 100);
                HunderterStelle(hunderter);
                int zehner = Mathf.FloorToInt((coinManager.coins - 100 * hunderter) / 10);
                ZehnerStelle(zehner);
                int einer = (int)((coinManager.coins - hunderter * 100) - zehner * 10);
                EinerStelle(einer);

            }
            else if (places >= 100)
            {
                //4 Stellen 1000-9999
                stellen = 4;
                int tausender = Mathf.FloorToInt(coinManager.coins / 1000);
                TausenderStelle(tausender);
                int hunderter = Mathf.FloorToInt((coinManager.coins - tausender * 1000) / 100);
                HunderterStelle(hunderter);
                int zehner = Mathf.FloorToInt(((coinManager.coins - 1000 * tausender) - 100 * hunderter) / 10);
                ZehnerStelle(zehner);
                int einer = (int)(((coinManager.coins - tausender * 1000) - hunderter * 100) - zehner * 10);
                EinerStelle(einer);
            }

            start = false;

        }


        coinsOld = coinManager.coins;
    }

    public void EinerStelle(int number)
    {
        switch(stellen)
        {
            case 1:
                if(einserBlock != null)
                {
                    Destroy(einserBlock);
                    Debug.Log(number);
                }
                einserBlock = Instantiate(numbers[number], new Vector3(0.0f, 34f, 0.0f), new Quaternion(0, 180, 0, 0));
                break;
            case 2:
                if (einserBlock != null)
                {
                    Destroy(einserBlock);
                    Debug.Log(number);
                }
                einserBlock = Instantiate(numbers[number], new Vector3(1.1f, 34f, 0.0f), new Quaternion(0, 180, 0, 0));
                break;
            case 3:
                if (einserBlock != null)
                {
                    Destroy(einserBlock);
                    Debug.Log(number);
                }
                einserBlock = Instantiate(numbers[number], new Vector3(2.2f, 34f, 0.0f), new Quaternion(0, 180, 0, 0));
                break;
            case 4:
                if (einserBlock != null)
                {
                    Destroy(einserBlock);
                    Debug.Log(number);
                }
                einserBlock = Instantiate(numbers[number], new Vector3(3.3f, 34f, 0.0f), new Quaternion(0, 180, 0, 0));
                break;

        }
    }

    public void ZehnerStelle(int number)
    {
        switch (stellen)
        {

            case 2:
                if (zehnerBlock != null)
                {
                    Destroy(zehnerBlock);
                }
                zehnerBlock = Instantiate(numbers[number], new Vector3(-1.1f, 34f, 0.0f), new Quaternion(0, 180, 0, 0));
                break;
            case 3:
                if (zehnerBlock != null)
                {
                    Destroy(zehnerBlock);
                }
                zehnerBlock = Instantiate(numbers[number], new Vector3(0.0f, 34f, 0.0f), new Quaternion(0, 180, 0, 0));
                break;
            case 4:
                if (zehnerBlock != null)
                {
                    Destroy(zehnerBlock);
                }
                zehnerBlock = Instantiate(numbers[number], new Vector3(1.1f, 34f, 0.0f), new Quaternion(0, 180, 0, 0));
                break;

        }
    }

    public void HunderterStelle(int number)
    {

        switch (stellen)
        {

            case 3:
                if (hunderterBlock != null)
                {
                    Destroy(hunderterBlock);
                }
                hunderterBlock = Instantiate(numbers[number], new Vector3(-2.2f, 34f, 0.0f), new Quaternion(0, 180, 0, 0));
                break;
            case 4:
                if (hunderterBlock != null)
                {
                    Destroy(hunderterBlock);
                }
                hunderterBlock = Instantiate(numbers[number], new Vector3(-1.1f, 34f, 0.0f), new Quaternion(0, 180, 0, 0));
                break;

        }
    }

    public void TausenderStelle(int number)
    {
        switch (stellen)
        {

            case 4:
                if (tausenderBlock != null)
                {
                    Destroy(tausenderBlock);
                }
                tausenderBlock = Instantiate(numbers[number], new Vector3(-3.3f, 34f, 0.0f), new Quaternion(0, 180, 0, 0));
                break;

        }
    }



}
