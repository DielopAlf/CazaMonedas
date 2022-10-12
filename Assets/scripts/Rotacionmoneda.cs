using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionmoneda : MonoBehaviour
    
{
    [SerializeField]
    float rotacionX = 10f; //Valor y direccion para rotar asignados, se le pone float para que sea editable.
    void Update()
    {
        transform.Rotate(rotacionX,0f,0f * Time.deltaTime); //Para que se realize el movimiento asignado en la direccion. 
        // y las otras direcciones permanezcan quietas.
    }
}
