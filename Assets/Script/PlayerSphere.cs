using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSphere : MonoBehaviour
{


    public ParticleSystem collectEffect;
    public ParticleSystem clickEffect;

    public Text scoreText;
    private float score;
    private int scoreInt;
    
    public float movementSpeed;


    private void Start()
    {
        score = 0;
       
    }

  

    void Update()
    {
  
        score += Time.deltaTime;


        transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);


        if (Input.GetMouseButtonDown(0))
        {
            clickEffectFun();
            //Rise up
          
            //Animation

        }
        

    }
    void FixedUpdate()
    {
        scoreInt = (int)score;
        scoreText.GetComponent<Text>().text = "Score: " + scoreInt * 10;
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Lantern")
            collectEffectFuntion();


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
