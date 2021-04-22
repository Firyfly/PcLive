using UnityEngine;

public class NumberManager : MonoBehaviour
{

    public GameObject einserBlock;
    public GameObject zehnerBlock;
    public GameObject hunderterBlock;
    public GameObject tausenderBlock;
    public GameObject einserUpgradeBlock;
    public GameObject zehnerUpgradeBlock;
    public GameObject[] numbers;

    public bool start = true;
    public float numberHeight = -1.2f;
    public bool updateHeight = false;
    public bool updateHeightOnceUp = true;
    public bool updateHeightOnceDown = false;
    public float coinsOld;
    public int stellen;
    public bool updateOnceStart = true;
    public float upgradeCoinsNew = 0;
    public float upgradeCoinsOld = 0;

    public PlayerController playerController;
    public CoinManager coinManager;

    void Start()
    {
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        coinsOld = coinManager.coins;
    }

    void Update()
    {
        //Updatet die upgradecoinsNew um diese mit upgradecoinsOld zu vergleichen ob sich etwas verändert
        upgradeCoinsNew = playerController.upgradeCost;

        //Wenn der Spieler im Bereich einer Upgrademaschine ist
        if(playerController.upgrading == true)
        {
            //setzt die Höhe der Nummern höher
            numberHeight = -3.0f;
            if (updateHeightOnceUp == true)
            {
                updateHeight = true;
                updateHeightOnceUp = false;
                updateHeightOnceDown = true;
            }

            //Wenn sich etwas verändert lösche die alten Zahlen um platz für die neuen zu machen
            if(upgradeCoinsNew != upgradeCoinsOld)
            {
                DeleteUpgradeNumbers();
            }

            //Instanziiert die (neuen)UpgradeCosten unter der normalen Bitcoin Anzeige
            if (updateOnceStart == true || upgradeCoinsNew != upgradeCoinsOld) {
                InstantiateUpgradeNumbers(playerController.upgradeCost);
                updateOnceStart = false;
            }

        }
        else
        {
            //Wenn Spieler in keinem Upgradebereich, dann setze alles zurück und halte es an dieser Stelle
            numberHeight = -1.2f;
            if (updateHeightOnceDown == true) {
                updateHeight = true;
                updateHeightOnceDown = false;
                updateHeightOnceUp = true;
                updateOnceStart = true;

                DeleteUpgradeNumbers();
            }

        }


        //Wenn sich die Anzahl an bitcoins ändert, dann Instanziiere die Anzeige neu
        if (coinsOld != coinManager.coins || start == true || updateHeight == true)
        {
            //Berechnet die Stellen
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

        updateHeight = false;
        coinsOld = coinManager.coins;
        upgradeCoinsOld = upgradeCoinsNew;
    }

    //Instanziiert die EinserStelle
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
                einserBlock = Instantiate(numbers[number], new Vector3(0.0f, 35f, numberHeight), new Quaternion(0, 180, 0, 0));
                break;
            case 2:
                if (einserBlock != null)
                {
                    Destroy(einserBlock);
                    Debug.Log(number);
                }
                einserBlock = Instantiate(numbers[number], new Vector3(1.1f, 35f, numberHeight), new Quaternion(0, 180, 0, 0));
                break;
            case 3:
                if (einserBlock != null)
                {
                    Destroy(einserBlock);
                    Debug.Log(number);
                }
                einserBlock = Instantiate(numbers[number], new Vector3(2.2f, 35f, numberHeight), new Quaternion(0, 180, 0, 0));
                break;
            case 4:
                if (einserBlock != null)
                {
                    Destroy(einserBlock);
                    Debug.Log(number);
                }
                einserBlock = Instantiate(numbers[number], new Vector3(3.3f, 35f, numberHeight), new Quaternion(0, 180, 0, 0));
                break;

        }
    }

    //Instanziiert die ZehnerStelle
    public void ZehnerStelle(int number)
    {
        switch (stellen)
        {

            case 2:
                if (zehnerBlock != null)
                {
                    Destroy(zehnerBlock);
                }
                zehnerBlock = Instantiate(numbers[number], new Vector3(-1.1f, 35f, numberHeight), new Quaternion(0, 180, 0, 0));
                break;
            case 3:
                if (zehnerBlock != null)
                {
                    Destroy(zehnerBlock);
                }
                zehnerBlock = Instantiate(numbers[number], new Vector3(0.0f, 35f, numberHeight), new Quaternion(0, 180, 0, 0));
                break;
            case 4:
                if (zehnerBlock != null)
                {
                    Destroy(zehnerBlock);
                }
                zehnerBlock = Instantiate(numbers[number], new Vector3(1.1f, 35f, numberHeight), new Quaternion(0, 180, 0, 0));
                break;

        }
    }

    //Instanziiert die HunderterStelle
    public void HunderterStelle(int number)
    {

        switch (stellen)
        {

            case 3:
                if (hunderterBlock != null)
                {
                    Destroy(hunderterBlock);
                }
                hunderterBlock = Instantiate(numbers[number], new Vector3(-2.2f, 35f, numberHeight), new Quaternion(0, 180, 0, 0));
                break;
            case 4:
                if (hunderterBlock != null)
                {
                    Destroy(hunderterBlock);
                }
                hunderterBlock = Instantiate(numbers[number], new Vector3(-1.1f, 35f, numberHeight), new Quaternion(0, 180, 0, 0));
                break;

        }
    }

    //Instanziiert die TausenderStelle
    public void TausenderStelle(int number)
    {
        switch (stellen)
        {

            case 4:
                if (tausenderBlock != null)
                {
                    Destroy(tausenderBlock);
                }
                tausenderBlock = Instantiate(numbers[number], new Vector3(-3.3f, 35f, numberHeight), new Quaternion(0, 180, 0, 0));
                break;

        }
    }

    //Löscht alle Zahlen um platz für die neuen zu machen
    public void ClearAll()
    {
        Destroy(einserBlock);
        Destroy(zehnerBlock);
        Destroy(hunderterBlock);
        Destroy(tausenderBlock);
    }




    public void InstantiateUpgradeNumbers(float upgradeCost)
    {

        int zehner = Mathf.FloorToInt(upgradeCost / 10);
        zehnerUpgradeBlock = Instantiate(numbers[zehner], new Vector3(-1.1f, 35f, 1), new Quaternion(0, 180, 0, 0));
        int einer = (int)upgradeCost - zehner * 10;
        einserUpgradeBlock = Instantiate(numbers[einer], new Vector3(1.1f, 35f, 1), new Quaternion(0, 180, 0, 0));
    }

    public void DeleteUpgradeNumbers()
    {
        if (einserUpgradeBlock != null)
        {
            Object.Destroy(einserUpgradeBlock);
        }
        if (zehnerUpgradeBlock != null)
        {
            Object.Destroy(zehnerUpgradeBlock);
        }
    }



}
