using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager sndMan;
    private AudioSource audioSource;
    private AudioClip[] coinSounds;
    private AudioClip[] boostSounds;
    private AudioClip[] hitSounds;
    private AudioClip[] dieSounds;

    private int randomCoinSounds;
    private int randomBoostSounds;
    private int randomHitSounds;
    private int randomDieSounds;

    

    void Start()
    {
        sndMan = this;
        audioSource = GetComponent<AudioSource>();
        coinSounds = Resources.LoadAll<AudioClip>("CoinSounds");
        boostSounds = Resources.LoadAll<AudioClip>("BoostSounds");
    

        dieSounds = Resources.LoadAll<AudioClip>("DieSounds");

    }

     void Update()
    {
       
    }

   
    public void PlayCoinSound()
    {
        randomCoinSounds = Random.Range(0, 2);
        audioSource.PlayOneShot(coinSounds[randomCoinSounds]);
     
    }
    public void PlayBoostSound()
    {
        
        randomBoostSounds = Random.Range(0, 2);
        audioSource.PlayOneShot(boostSounds[randomBoostSounds]);
    }
   
    public void PlayDieSound()
    {
        randomDieSounds = Random.Range(0, 2);
        audioSource.PlayOneShot(dieSounds[randomDieSounds]);
    }

}
