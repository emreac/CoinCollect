using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelsButton : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Start is called before the first frame update
    public void LevelsMenu()
    {
        SceneManager.LoadScene("LevelSelection");
    }
}
