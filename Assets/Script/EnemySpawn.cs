using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{


    public GameObject fakePlayer;


    public GameObject enemy;


    public float amountOfObstacles;

    public float minX, maxX;

    private void Start()
    {



        // fakePlayer = GameObject.FindWithTag("fakePlayer");


        fakePlayer = GameObject.FindGameObjectWithTag("fakePlayer");

        for (int i = 0; i < amountOfObstacles; i++)
        {
            float xAxis, yAxis;
            xAxis = Random.Range(minX, maxX);
            yAxis = Random.Range(-fakePlayer.transform.localPosition.x - 18, -fakePlayer.transform.localPosition.x - 50);

            Vector3 pos = new Vector3(-yAxis, xAxis, 0);
            Instantiate(enemy.transform, pos, Quaternion.identity);

        }
    }





}
