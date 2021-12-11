using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 InitialPos = new Vector3(0, 100, 0);

    public float Speed = 10f;
    public float TurnSpeed = 15f;
    private float VerticalInput;
    private float HorizontalInput;

    private float YLimit = 200f;
    private float NegativeYLimit = -200f;
    private float XLimit = 200f;
    private float NegativeXLimit = 0f;
    private float ZLimit = 200f;
    private float NegativeZLimit = -200f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = InitialPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

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

        if (transform.position.y > NegativeYLimit)
        {
            transform.position = new Vector3(transform.position.x, NegativeYLimit, transform.position.z);
        }
        if (transform.position.x > NegativeXLimit)
        {
            transform.position = new Vector3(NegativeXLimit, transform.position.y, transform.position.z);
        }
        if (transform.position.z > NegativeZLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, NegativeZLimit);
        }
    }
}
