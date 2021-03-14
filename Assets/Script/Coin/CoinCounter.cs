using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinCounter : MonoBehaviour
{
    public PlayerSphere playerSphere;
    public PlayerSprite player;
    public FakePlayerMove fakePlayer;
    public float movementSpeed;

    public static CoinCounter instance;
    public Text text;
    public int coinScore;
    private float boosterTimer;
    private bool boosting;
    public int currentHealth;






    // Start is called before the first frame update
    void Start()
    {
         

        if (instance == null)
        {
            instance = this;
        }

        

    }

    // Update is called once per frame
    void Update()
    {
       


    }
    
    
    public void speedBoosterNormal()
    {
       
            player.movementSpeed = 3;
            fakePlayer.movementSpeed = 3;
        
        

    }

   
    public void ChangeScore(int coinValue)
    {
    
        coinScore += coinValue;
        text.text = "X" + coinScore.ToString();

      

        for (int i = 0; i < coinScore; i++)
        {

             if (coinScore % 10 == 0)
                {
                   
                    player.movementSpeed = 5;
                    fakePlayer.movementSpeed = 5;
                playerSphere.currentHealth = 100;

              
                Invoke("speedBoosterNormal", 2);
             
                    
         
         
            }

            

           

        }


    }


   

}


