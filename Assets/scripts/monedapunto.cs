using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monedapunto : MonoBehaviour
{
    public GameObject ObjectPuntos;
    public float puntosQueDa;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            ObjectPuntos.GetComponent<Puntos>().puntos +=puntosQueDa;
            Destroy(gameObject);
        }
    }

    
    
}
