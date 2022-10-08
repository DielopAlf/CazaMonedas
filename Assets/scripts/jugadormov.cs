using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jugadormov : MonoBehaviour
{
    int contador;
    Rigidbody body;
    Vector2 direction;
    public float Monedas;
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    public AudioSource Moneda;
    public AudioSource Musica;

    public GameObject SonidoMoneda;
    public GameObject SonidoCaida;

    public float velocidaddeMovimiento = 1.5f;

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador =  contador +1;

    }
    public void Awake()
    {
        body =GetComponent<Rigidbody>();
        contador = 0; 
    }

    [SerializeField]
    float IMPULSE = 2F;

    private void Start()
    {
        
    }



    void Update()
    {

        movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime* IMPULSE * velocidaddeMovimiento;
        movimientoEjeZ= Input.GetAxis("Vertical")*Time.deltaTime* IMPULSE * velocidaddeMovimiento;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);


    }
}
