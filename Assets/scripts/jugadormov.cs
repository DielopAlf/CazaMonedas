using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jugadormov : MonoBehaviour
{
//Para definir el cuerpo solido del jugador y su direccion.
    int contador;
    Rigidbody rb;
    Vector2 direction;

    //Datos de la Pantalla final.
    [SerializeField]
    public Text puntuacion;
    public Image final;
    public Text Victoria;
    public Button text;

    
    
    //datos del impulso.
    float IMPULSE = 2F;

    
    //Partículas
    [SerializeField]
    GameObject prebaParticles;

    
    //Datos de las direcciones y velocidad del  movimiento del jugador.
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;
  
    //Se eligue la velocidad del jugador.
    public float velocidaddeMovimiento = 1.5f;
    
    //Esto es para que las monedas desaparezcan al ser tocadas y sumen un punto.
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); // Para que las monedas cuando se toquen desaparezcan.
        contador = contador +1; //Cada vez que se coga una moneda sumara un punto.
        actualizarmarcador(); //Aqui usé un  método llamado extract Method  (se realiza seleccionando el texto y presionando ctrl+.) 
        //esto es para poder cambiar el no,bre puntuacion de la linea usada (puntuacion.text="puntuacion"+contador;) para que el texto 
        //se vaya modificando.

       if (contador>= 10) //Asignando el valor elegido para ganar el juego.
            {
            Victoria.gameObject.SetActive(true);//la meta se activara cuando se llegue a dicho valor.
          

        }

    }

    private void actualizarmarcador() 
    {
        puntuacion.text="Monedas:"+contador; //para asignar el texto de monedas  la pantalla y este vaya aumentando.
    }

    public void Awake()
    {
        rb=GetComponent<Rigidbody>();//Para que el jugador empieze con 0 monedas y vayan sumandose a medida que las coga.
        contador = 0;
        actualizarmarcador();
        Victoria.gameObject.SetActive(false); //Para que al llegar a los 10 puntos aparezca la pantalla de victoria.

       
    }


   
    public void FixedUpdate() 

    //Se uso get axis para que fuese tambien posible jugar con mando y flechas tambien en esta parte se definen las direcciones del jugador.
    {
       //asignando las direcciones en las que avanzara el jugador a la velocidad que avanzara.
        movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime* IMPULSE * velocidaddeMovimiento;
        movimientoEjeZ= Input.GetAxis("Vertical")*Time.deltaTime* IMPULSE * velocidaddeMovimiento;
        transform.Translate(movimientoEjeX, movimientoEjeY,movimientoEjeZ);
    }



}
