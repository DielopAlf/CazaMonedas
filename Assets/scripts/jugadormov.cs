using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jugadormov : MonoBehaviour
{
    int contador;
    Rigidbody rb;
    public Text puntuacion;
    public Text Victoria;
    Vector2 direction;
    [SerializeField]
    float IMPULSE = 2F;

    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;


  
    public float velocidaddeMovimiento = 1.5f;

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador +1;
        actualizarmarcador();
       if (contador>= 10)
            {
            Victoria.gameObject.SetActive(true); 
              
             }

    }

    private void actualizarmarcador() 
    {
        puntuacion.text="Monedas:"+contador;
    }

    public void Awake()
    {
        rb=GetComponent<Rigidbody>();
        contador = 0;
        actualizarmarcador();
        Victoria.gameObject.SetActive(false);
    }


 
    void Update()
    {

        movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime* IMPULSE * velocidaddeMovimiento;
        movimientoEjeZ= Input.GetAxis("Vertical")*Time.deltaTime* IMPULSE * velocidaddeMovimiento;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);


    }
}
