using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextlevelButton : MonoBehaviour
{
   
    public void GoNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name + 1);
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
