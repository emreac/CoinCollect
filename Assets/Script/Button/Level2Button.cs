using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Button : MonoBehaviour
{
   
    public void GoLevel2()
    {
        
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
