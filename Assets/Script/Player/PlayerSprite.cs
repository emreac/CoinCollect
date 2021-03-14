using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSprite : MonoBehaviour
{
    public PlayerSprite player;
 
   // public CoinCounter coinCounter;
    public int coinScore;

    public float velocity = 1;
    private Rigidbody2D rb;
    private Text text;
    public static CoinCounter instance;

    public ParticleSystem fastEffect;


    //Movement
    public float movementSpeed;
    public float boostTimer;
    public bool boosting;
    public ParticleSystem ParticleSystemBoost2;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

      

    }

    private void FixedUpdate()
    {
        if (movementSpeed > 3)
        {
            SoundManager.sndMan.PlayBoostSound();
            boost2();
            fastEffectFun();
        }
    }





    // Update is called once per frame
    void Update()
    {
    


        //Movement Right
        transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);



        if (Input.GetMouseButtonDown(0))
        {

            //Rise up
            rb.velocity = Vector2.up * velocity;

        }


       



    }
    void boost2()
    {
        ParticleSystemBoost2.Play();
    }

    void fastEffectFun()
    {
        fastEffect.Play();
    }



}



  