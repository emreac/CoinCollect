using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSphere : MonoBehaviour
{

  
    public CoinCounter coinCounter;


    public HealthBar healthBar;

    public int maxHealth = 100;
    public int currentHealth;

    public ParticleSystem collectEffect;
    public ParticleSystem clickEffect;

    public Text scoreText;
    private float score;
    private int scoreInt;
    public int scoreLast;
    
    public float movementSpeed;


    private void Start()
    {
        currentHealth = maxHealth;
        score = 0;
        healthBar.SetMaxHealth(maxHealth);
    }

  

    void Update()
    {
  
        score += Time.deltaTime;


        transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);


        if (Input.GetMouseButtonDown(0))
        {
            clickEffectFun();
         

        }

      
        


    }
    void FixedUpdate()
    {
        scoreInt = (int)score;
        scoreLast = scoreInt * 10;
        scoreText.GetComponent<Text>().text = "Score: " + scoreLast;
       
 
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameScene");
          
        }
        
    }


 


    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Lantern")
        {
            takeRecover(2);
            healthBar.SetHealth(currentHealth);
            collectEffectFuntion();

        }
           

        if (other.tag == "Enemy")
        {
            takeDamege(20);
            healthBar.SetHealth(currentHealth);
        }
      
    }




    void takeDamege(int damage)
    {
        currentHealth -= damage;
    
    }
    void takeRecover(int recover)
    {
        currentHealth += recover;
    }

    void collectEffectFuntion()
    {
        collectEffect.Play();
    }

    void clickEffectFun()
    {
        clickEffect.Play();
    }
}
