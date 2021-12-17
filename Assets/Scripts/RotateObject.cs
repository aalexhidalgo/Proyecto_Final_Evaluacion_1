using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    //Velocidad de rotación
    public float Speed = 50f;

    void Update()
    {
        //Dirección de rotación de los objetos
        transform.Rotate(Vector3.up * Speed * Time.deltaTime);

    }
}
