using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSphere : MonoBehaviour
{

    public int levelToUnlock = 2;
    //heart system


    
    //boost system

    public BoostBar boostBar;
    public int maxBoostUi = 10;
    public int currentBoostUi;
    private bool isMatched;




    public Animator camAnim;



    public NextLevelControl NextLevelControl;
    public GameOverPopUp GameOverPopUp;
    private CoinCounter coinCounter;

    public PlayerSprite PlayerSprite;

    public HealthBar healthBar;

    public int maxHealth = 100;
    public int currentHealth;

    public ParticleSystem DamageEffect;

    public ParticleSystem collectEffect;
    public ParticleSystem clickEffect;

    public Text scoreTextNewLevel;
    public Text scoreText;
    public Text gameOverScoreText;
    private float score;
    private int scoreInt;
    public int scoreLast;
    
    public float movementSpeed;

    Collider m_Collider;

    private void Start()
    {
        currentBoostUi = maxBoostUi;
        m_Collider = GetComponent<Collider>();


        currentHealth = maxHealth;
        score = 0;
        healthBar.SetMaxHealth(maxHealth);
    }

  

    void Update()
    {

        if (movementSpeed == 5)
        {
            m_Collider.enabled = false;
        }




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
        gameOverScoreText.GetComponent<Text>().text = "Score: " + scoreLast;
        scoreTextNewLevel.GetComponent<Text>().text = "You Have Reached " + scoreLast + " Points" ;


     
        if (scoreLast >= 1000)
        {

            NextLevel();
            PlayerPrefs.SetInt("levelReached",levelToUnlock);
            Destroy(this.gameObject);
            Destroy(PlayerSprite);



        }


        if (currentBoostUi % 10 == 0)
        {

            currentBoostUi = 0;
            
        }

        if (currentHealth <= 0)
        {
            
            GameOver();
            Destroy(this.gameObject);
            Destroy(PlayerSprite);
          
           
       //     GameOver();
          //  SceneManager.LoadScene("GameScene");
          
        }
        
    }


    public void WinLevel()
    {
        Debug.Log("level won");
    }

    public void GameOver()
    {
        GameOverPopUp.Setup(scoreLast);
    }
 
    public void NextLevel()
    {
        NextLevelControl.Setup(scoreLast);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Capsule")
        {

            camShake();
            SoundManagerHit.sndManHit.PlayHitSound();
            DamageEfectFun();
            takeDamege(10);
            healthBar.SetHealth(currentHealth);
        }

        if (other.tag == "Lantern")
        {

            SoundManager.sndMan.PlayCoinSound();
            getCoinBoost(1);
            takeRecover(2);
            healthBar.SetHealth(currentHealth);
            collectEffectFuntion();
            boostBar.SetBoost(currentBoostUi);

        }

      

        if (other.tag == "Enemy" )
        {
            
            SoundManagerHit.sndManHit.PlayHitSound();
            camShake();
            DamageEfectFun();
            takeDamege(40);
            healthBar.SetHealth(currentHealth);
            
        }
    
           // myMaterial.color = Color.white;

        
      
    }


    void NextLevelParticles()
    {

    }

    void getCoinBoost(int getcoin)
    {
        currentBoostUi += getcoin;
       // boostBar.SetBoost(currentBoostUi);
    }
    void loseCoinBoost(int losecoin)
    {
        currentBoostUi -= losecoin;
        // boostBar.SetBoost(currentBoostUi);
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

    void DamageEfectFun()
    {
        DamageEffect.Play();
    }
 
  
    void clickEffectFun()
    {
        clickEffect.Play();
    }

    public void camShake()
    {
        camAnim.SetTrigger("shake");
    }
}
