using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteManager : MonoBehaviour
{
    public static MuteManager mtMan;
    private bool isMuted;

    // Start is called before the first frame update
    void Start()
    {
        mtMan = this;
        isMuted = false;
    }

    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;

    }

    
    
}
