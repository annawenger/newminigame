using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{

    public GameObject ball;
    public GameObject spitze;
    public GameObject boundryR;
    public GameObject boundryL;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    public float spawnRateS = 3f;
    float nextSpawn = 0.0f;
    float timer;

    void Update()
    {
        SpawnBall();
        SpawnSpitze();
    }

    private void SpawnBall()
    {
        timer = timer + Time.deltaTime;
        Debug.Log(timer);
        if (timer > spawnRate)
        {
            randX = Random.Range(boundryL.transform.position.x, boundryR.transform.position.x);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(ball, whereToSpawn, Quaternion.identity);
            timer = 0f;
        }
    }

    private void SpawnSpitze()
    {
        timer = timer + Time.deltaTime;
        Debug.Log(timer);
        if (timer > spawnRate)
        {
            randX = Random.Range(boundryL.transform.position.x, boundryR.transform.position.x);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(spitze, whereToSpawn, Quaternion.identity);
            timer = 0f;
        }
    }

}

