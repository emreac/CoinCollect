using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPopUp : MonoBehaviour
{


    public PlayerSphere player;
    private int scoreInt;
    public Text scoreText;
    public int scoreLast;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.GetComponent<Text>().text = "Score: " + scoreLast;

    }
}
