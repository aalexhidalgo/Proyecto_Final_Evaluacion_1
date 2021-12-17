using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //Límites
    private float YLimit = 200f;
    private float XLimit = 200f;
    private float ZLimit = 200f;
    private float YZero = 0;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > YLimit)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > XLimit)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > ZLimit)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < YZero)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -XLimit)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -ZLimit)
        {
            Destroy(gameObject);
        }
    }
}