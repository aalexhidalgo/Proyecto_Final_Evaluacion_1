using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    //Limites pantalla
    private float XLimit = 170f;
    private float YLimit = 170f;
    private float ZLimit = 170f;
    private float YZero = 0;

    void Start()
    {
        //El recolectable se genera de manera aleatoria dentro de los limites de pantalla
        transform.position = new Vector3(Random.Range(-XLimit, XLimit), Random.Range(YZero, YLimit), Random.Range(-ZLimit, ZLimit));
    }
}
