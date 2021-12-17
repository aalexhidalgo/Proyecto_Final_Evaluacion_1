using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    private float Speed = 70f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
