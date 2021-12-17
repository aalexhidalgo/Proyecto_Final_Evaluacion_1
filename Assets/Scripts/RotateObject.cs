using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    //Velocidad de rotaci�n
    public float Speed = 50f;

    void Update()
    {
        //Direcci�n de rotaci�n de los objetos
        transform.Rotate(Vector3.up * Speed * Time.deltaTime);

    }
}
