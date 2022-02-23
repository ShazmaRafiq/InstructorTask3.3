using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnRangeX = 5;
    private float spawnPosZ = -1;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomBall()
    {

        //Randomly generate ball index and spawn position

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 5, -1);

        int ballIndex = Random.Range(0, ballPrefabs.Length);

        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}
