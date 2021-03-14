using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPopUp : MonoBehaviour
{
    void Start()
    {
        SoundManager.sndMan.PlayDieSound();

    }


    public PlayerSphere player;
    private int scoreInt;
    public Text scoreText;
    public int scoreLast;

    public void Setup (int scoreLast)
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
