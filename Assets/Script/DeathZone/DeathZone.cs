using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    public int scoreLast;

    public PlayerSprite PlayerSprite;
    public PlayerSphere PlayerSphere;
    public GameOverPopUp GameOverPopUp;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(PlayerSprite);
            Destroy(PlayerSphere);
            GameOver();
        }
    }

    public void GameOver()
    {
        GameOverPopUp.Setup(scoreLast);
    }

}
