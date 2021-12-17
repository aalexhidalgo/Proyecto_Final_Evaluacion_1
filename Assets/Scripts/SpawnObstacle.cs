using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    //Límites
    private float YLimit = 170f;
    private float XLimit = 170f;
    private float ZLimit = 170f;
    private float YZero = 0;
    
    public GameObject ObstaclePrefab;
    private Vector3 spawnPosition;

    private float StartTime = 2f;
    private float RepeatRate = 5f;

    void Start()
    {
        //Función que llama al obstáculo la primera vez tras 5 segundos de empezar el jugeo y las siguientes cada dos
        InvokeRepeating("SpawnObstaclePrefab", StartTime, RepeatRate);
    }

    public Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(-XLimit, XLimit), Random.Range(YZero, YLimit), Random.Range(-ZLimit, ZLimit));
    }

    public void SpawnObstaclePrefab()
    {

        spawnPosition = RandomSpawnPosition();
        Instantiate(ObstaclePrefab, spawnPosition, ObstaclePrefab.transform.rotation);
    }
}
