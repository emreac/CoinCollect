using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternsSpawn : MonoBehaviour
{

  
    public GameObject fakePlayer;
    public float x;

    public GameObject lantern;


    public float amountOfObstacles;

    public float minX, maxX;

    private void Start()
    {



       // fakePlayer = GameObject.FindWithTag("fakePlayer");


        fakePlayer = GameObject.FindGameObjectWithTag("fakePlayer");

        for (int i = 0; i < amountOfObstacles; i++)
        {
            x = Random.Range(0.1f, 0.2f);

            Vector3 randomSize = new Vector3(x, x, 1);
            lantern.transform.localScale = randomSize;

            float xAxis, yAxis;
            xAxis = Random.Range(minX, maxX);
            yAxis = Random.Range(-fakePlayer.transform.localPosition.x - 20, -fakePlayer.transform.localPosition.x - 60);

            Vector3 pos = new Vector3(-yAxis, xAxis, 0);
            Instantiate(lantern.transform, pos, Quaternion.identity);

        }
    }


   
}
