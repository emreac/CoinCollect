using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Button : MonoBehaviour
{
   
    public void GoLevel2()
    {
        SceneManager.LoadScene("GameScene2");
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
