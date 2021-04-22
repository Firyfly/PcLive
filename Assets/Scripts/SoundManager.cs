using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public GameObject walkObject;
    public GameObject UpgradeMaschineObject;
    public GameObject SwitchSidesObject;
    public GameObject BoxPickUpObject;
    public GameObject IceMeltObject;
    public GameObject ElectricityObject;
    public GameObject CoinPickUpObject;
    public GameObject BackgroundMusicObject;
    public GameObject DropBoxObject;
    public GameObject correctObject;
    public GameObject WrongObject;
    public GameObject LabyrinthObject;
    public GameObject TimerObject;

    public AudioSource walkSound;
    public AudioSource UpgradeMaschineSound;
    public AudioSource SwitchSidesSound;
    public AudioSource BoxPickUpSound;
    public AudioSource IceMeltSound;
    public AudioSource ElectricitySound;
    public AudioSource CoinPickUpSound;
    public AudioSource BackgroundMusicSound;
    public AudioSource DropBoxSound;
    public AudioSource CorrectSound;
    public AudioSource WrongSound;
    public AudioSource LabyrinthStartSound;
    public AudioSource TimerSound;

    // Start is called before the first frame update
    void Start()
    {

        walkSound = walkObject.GetComponent<AudioSource>();
        UpgradeMaschineSound = UpgradeMaschineObject.GetComponent<AudioSource>();
        SwitchSidesSound = SwitchSidesObject.GetComponent<AudioSource>();
        BoxPickUpSound = BoxPickUpObject.GetComponent<AudioSource>();
        IceMeltSound = IceMeltObject.GetComponent<AudioSource>();
        ElectricitySound = ElectricityObject.GetComponent<AudioSource>();
        CoinPickUpSound = CoinPickUpObject.GetComponent<AudioSource>();
        BackgroundMusicSound = BackgroundMusicObject.GetComponent<AudioSource>();
        DropBoxSound = DropBoxObject.GetComponent<AudioSource>();
        CorrectSound = correctObject.GetComponent<AudioSource>();
        WrongSound = WrongObject.GetComponent<AudioSource>();
        LabyrinthStartSound = LabyrinthObject.GetComponent<AudioSource>();
        TimerSound = TimerObject.GetComponent<AudioSource>();

    }

    public void Update()
    {
        
    }

    //aufrufbare Funktionen um die verschiedenen Sounds zu spielen
    public void PlayWalk()
    {
        walkSound.Play(); 
    }

    public void PlayUpgrade()
    {
        UpgradeMaschineSound.Play();
    }

    public void PlaySwitch()
    {
        SwitchSidesSound.Play();
    }

    public void PlayBoxPickUp()
    {
        BoxPickUpSound.Play();
    }

    public void PlayIceMelt()
    {
        IceMeltSound.Play();
    }

    public void PlayElectricity()
    {
        ElectricitySound.Play();
    }

    public void PlayCoin()
    {
        CoinPickUpSound.Play();
    }

    public void PlayBackground()
    {
        BackgroundMusicSound.Play();
    }

    public void PlayDropBox()
    {
        DropBoxSound.Play();
    }

    public void PlayCorrect()
    {
        CorrectSound.Play();
    }

    public void PlayWrong()
    {
        WrongSound.Play();
    }

    public void PlayLabyrinthStart()
    {
        LabyrinthStartSound.Play();
    }

    public void PlayTimer()
    {
        TimerSound.Play();
    }
    public void StopTimer()
    {
        TimerSound.Stop();
    }
}
