using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{   
    //Velocidad proyectil
    private float Speed = 70f;

    // Update is called once per frame
    void Update()
    {
        //Movimiento constante hacia adelante del Proyectil
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
