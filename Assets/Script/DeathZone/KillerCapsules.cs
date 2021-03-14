using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerCapsules : MonoBehaviour
{

    public PlayerSphere PlayerSphere;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(PlayerSphere);
        }
    }
}
