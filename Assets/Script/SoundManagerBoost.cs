using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerBoost : MonoBehaviour
{

    public static SoundManagerBoost sndManBoost;
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
        sndManBoost = this;
        audioSource = GetComponent<AudioSource>();

        boostSounds = Resources.LoadAll<AudioClip>("BoostSounds");


    }

     void Update()
    {
       
    }

   
 
    public void PlayBoostSound()
    {
        
        randomBoostSounds = Random.Range(0, 2);
        audioSource.PlayOneShot(boostSounds[randomBoostSounds]);
    }
 


}
