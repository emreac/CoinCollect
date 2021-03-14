using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDroneSpawn1 : MonoBehaviour
{





    public GameObject fakePlayer;


    public GameObject enemy;


    public float amountOfObstacles;

    public float minX, maxX;

    public float cubeSizeWidthMin = 1f;
    public float cubeSizeWidthMax = 3f;
    public float x;


    private void Start()
    {




        // fakePlayer = GameObject.FindWithTag("fakePlayer");


        fakePlayer = GameObject.FindGameObjectWithTag("fakePlayer");

        for (int i = 0; i < amountOfObstacles; i++)
        {

          


            x = Random.Range(0.07f, 0.1f);

            Vector3 randomSize = new Vector3(x,x, 0.001f);

            enemy.transform.localScale = randomSize;

            float xAxis, yAxis;
            xAxis = Random.Range(minX, maxX);
            yAxis = Random.Range(-fakePlayer.transform.localPosition.x - 18, -fakePlayer.transform.localPosition.x - 50);

            Vector3 pos = new Vector3(-yAxis, xAxis, 0);
            Instantiate(enemy.transform, pos, Quaternion.identity);


           


        }


  
    }


    void Update()
    {

       

    }



}
