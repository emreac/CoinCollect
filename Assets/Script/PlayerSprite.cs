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
    public Text text;
    public static CoinCounter instance;


    //Movement
    public float movementSpeed;
    public float boostTimer;
    public bool boosting;
 


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

   

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


    

    
}



  