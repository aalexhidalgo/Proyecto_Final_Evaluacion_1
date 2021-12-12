using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 InitialPos = new Vector3(0, 0, 0);

    private float Speed = 10f;
    private float TurnSpeed = 20f;
    private float VerticalInput;
    private float HorizontalInput;

    private float YLimit = 200f;
    private float XLimit = 200f;
    private float ZLimit = 200f;

    // Start is called before the first frame update
    void Start()
    {
        //Posición Inicial
        transform.position = InitialPos;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        VerticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * TurnSpeed * Time.deltaTime * VerticalInput);
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * TurnSpeed * Time.deltaTime * HorizontalInput);

        
        if (transform.position.y > YLimit)
        {
            transform.position = new Vector3(transform.position.x, YLimit, transform.position.z);
        }
        if (transform.position.x > XLimit)
        {
            transform.position = new Vector3(XLimit, transform.position.y, transform.position.z);
        }
        if (transform.position.z > ZLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ZLimit);
        }

        if (transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        if (transform.position.x < -XLimit)
        {
            transform.position = new Vector3(-XLimit, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -ZLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -ZLimit);
        }
        
    }
}
