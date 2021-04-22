using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryManager : MonoBehaviour
{

    public GameObject[] places;

    public Material grey1;
    public Material green1;
    public Material red1;

    public Material grey0;
    public Material green0;
    public Material red0;

    public ParticleSystem correctParticles;

    private int[] binary;
    public bool generated = false;
    public bool initialised = false;

    public int currentCheckBlock = 0;
    
    public float cpuCoinReward = 5;
    public float cpuDestroyBlockTime = 5;

    public float ScrollX = 0.0f;
    public float ScrollY = -0.5f;
   
    public CoinManager coinManager;
    public SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        binary = new int[4];
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Generiere Reihenfolge von 0 und 1
        if(generated == false)
        {
            for(int i = 0; i <= 3; i++)
            {
                int rand = Random.Range(0, 2);
                binary[i] = rand;
              
            }
            generated = true;
        }

        //Setze die Materialien auf Standart wenn nicht bereits generiert, Grau
        if(generated == true)
        {

            if (initialised == false)
            {
                if (binary[0] == 0)
                {
                    places[0].GetComponent<Renderer>().material = grey0;
                }
                else
                {
                    places[0].GetComponent<Renderer>().material = grey1;
                }

                if (binary[1] == 0)
                {
                    places[1].GetComponent<Renderer>().material = grey0;
                }
                else
                {
                    places[1].GetComponent<Renderer>().material = grey1;
                }

                if (binary[2] == 0)
                {
                    places[2].GetComponent<Renderer>().material = grey0;
                }
                else
                {
                    places[2].GetComponent<Renderer>().material = grey1;
                }

                if (binary[3] == 0)
                {
                    places[3].GetComponent<Renderer>().material = grey0;
                }
                else
                {
                    places[3].GetComponent<Renderer>().material = grey1;
                }

                initialised = true;
            }


        }


        //Scrolls das tiling von Laufband
        float OffsetX = Time.time * ScrollX;
        float OffsetY = Time.time * ScrollY;
        GameObject.Find("Conveyor0").GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX, OffsetY);

    }





    //Überprüft ob die abgegebene Blocknummer die richtige ist
    public void BlockCheck(int binaryNumber)
    {
        //Die Zahlen stimmen überein
        if (binary[currentCheckBlock] == binaryNumber)
        {
            if (binary[currentCheckBlock] == 0)
            {
                places[currentCheckBlock].GetComponent<Renderer>().material = green0;
               
            }
            else
            {
                places[currentCheckBlock].GetComponent<Renderer>().material = green1;
            }

            if (currentCheckBlock == 3)
            {
                
                Invoke("ResetBinaries", 1f);
                coinManager.CoinsAdd(cpuCoinReward);
                soundManager.PlayCoin();
                correctParticles.Play();

            }
            else
            {
                currentCheckBlock += 1;
            }

            soundManager.PlayCorrect();
        }//Die Zahlen stimmen nicht überein
        else if (binary[currentCheckBlock] != binaryNumber)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (binary[i] == 0)
                {
                    places[i].GetComponent<Renderer>().material = red0;
                }
                else
                {
                    places[i].GetComponent<Renderer>().material = red1;
                }
            }

            Invoke("ResetBinaries", 1f);

            soundManager.PlayWrong();

        }
    } 

    //Resettet alle Variablen
    void ResetBinaries()
    {
        generated = false;
        initialised = false;
        currentCheckBlock = 0;
    }





}
