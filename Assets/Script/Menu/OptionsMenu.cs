﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OptionsMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionMenu");
    }
}
