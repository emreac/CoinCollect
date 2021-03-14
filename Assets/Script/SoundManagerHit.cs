using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerHit : MonoBehaviour
{

    public static SoundManagerHit sndManHit;
    private AudioSource audioSource;

    private AudioClip[] hitSounds;


    private int randomCoinSounds;
    private int randomBoostSounds;
    private int randomHitSounds;
    private int randomDieSounds;

    

    void Start()
    {
        sndManHit = this;
        audioSource = GetComponent<AudioSource>();
    
        hitSounds = Resources.LoadAll<AudioClip>("HitSounds");


    }

     void Update()
    {
       
    }

   
  
    public void PlayHitSound()
    {
        randomHitSounds = Random.Range(0, 2);
        audioSource.PlayOneShot(hitSounds[randomHitSounds]);
    }
  

}
