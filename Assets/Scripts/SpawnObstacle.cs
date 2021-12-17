using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    //L�mites
    private float YLimit = 170f;
    private float XLimit = 170f;
    private float ZLimit = 170f;
    private float YZero = 0;

    public GameObject ObstaclePrefab;
    private Vector3 SpawnPos;

    private float StartTime = 1f;
    private float RepeatRate = 5f;

    //Funci�n que determina en que posici�n se generar� el obst�culo
    public void SpawnObstaclePrefab()
    {

        SpawnPos = new Vector3(Random.Range(-XLimit, XLimit), Random.Range(YZero, YLimit), Random.Range(-ZLimit, ZLimit));
        Instantiate(ObstaclePrefab, SpawnPos, ObstaclePrefab.transform.rotation);
    }

    void Start()
    {
        //Funci�n que llama al obst�culo la primera vez tras 1 segundo  de empezar el jugeo y las siguientes cada 5
        InvokeRepeating("SpawnObstaclePrefab", StartTime, RepeatRate);
    }
}
