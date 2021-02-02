using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelControl : MonoBehaviour
{

    public PlayerSphere player;
    private int scoreInt;
    public Text scoreTextNewLevel;
    public int scoreLast;



    void Start()
    {
       
    }
    public void Setup(int scoreLast)
    {
        gameObject.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
