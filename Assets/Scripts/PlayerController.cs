using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Posici�n
    private Vector3 InitialPos = new Vector3(0, 100, 0);

    //Velocidad y ejes
    [SerializeField]private float Speed = 30f;
    private float TurnSpeed = 25f;
    private float VerticalInput;
    private float HorizontalInput;

    //L�mites
    private float YLimit = 200f;
    private float XLimit = 200f;
    private float ZLimit = 200f;
    private float YZero = 0;

    public GameObject ProjectilePrefab;

    //Recuento de monedas
    private int CoinCounter = 0;

    //Funci�n para recoger las monedas y el bid�n de gasolina
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Coin"))
        {
            CoinCounter += 1;
            Destroy(otherCollider.gameObject);
            if (CoinCounter <= 3)
            {
                Debug.Log($"�Tienes un total de {CoinCounter} monedas, sigue as�!");
            }
            else if (CoinCounter <= 6)
            {
                Debug.Log($"�Tienes un total de {CoinCounter} monedas, ya queda menos!");
            }
            else if (CoinCounter <= 9)
            {
                Debug.Log($"�Tienes un total de {CoinCounter} monedas, est�s cerca!");
            }
            else if (CoinCounter == 10)
            {
                Time.timeScale = 0;
                Debug.Log($"Tienes un total de {CoinCounter} monedas �HAS GANADO!");
            }
        }
        //EXTRA: Si el Player recoge un bid�n de gasolina incrementa su velocidad
        if (otherCollider.gameObject.CompareTag("Gasoline"))
        {
            Speed += 10;
            Destroy(otherCollider.gameObject);
            Debug.Log($"�Enhorabuena! Has incrementado tu velocidad a {Speed}");
        }
    }

    void Start()
    {
        //Posici�n Inicial
        transform.position = InitialPos;
        //Muestra el total del recuento de monedas
        Debug.Log(CoinCounter);
    }

    void Update()
    {
        //Movimiento constante hacia adelante del Player
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        //Ejes que coge el Player para moverse de arriba a abajo y de izquierda a derecha
        VerticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.left * TurnSpeed * Time.deltaTime * VerticalInput);
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * TurnSpeed * Time.deltaTime * HorizontalInput);

       //L�mites que el Player no podr� superar creando una pared invisible para limitar su movimiento
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

        if (transform.position.y < YZero)
        {
            transform.position = new Vector3(transform.position.x, YZero, transform.position.z);
        }
        if (transform.position.x < -XLimit)
        {
            transform.position = new Vector3(-XLimit, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -ZLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -ZLimit);
        }

        //Controlador del proyectil
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(ProjectilePrefab, transform.position, gameObject.transform.rotation);
        }
    }
}
