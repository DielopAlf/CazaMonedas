using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadormov : MonoBehaviour
{

    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    public float velocidaddeMovimiento = 1.5f;

    Rigidbody body;
    Vector2 direction;

    [SerializeField]
    float IMPULSE = 4F;

   
   
    
    
   void Update()
    {

        movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime* IMPULSE * velocidaddeMovimiento;
        movimientoEjeZ= Input.GetAxis("Vertical")*Time.deltaTime* IMPULSE * velocidaddeMovimiento;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);


    }
}
