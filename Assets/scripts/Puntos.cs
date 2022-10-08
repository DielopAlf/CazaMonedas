using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    
  
  public float puntos;
  public Text textoPuntos;

    private void Update()
    {
        textoPuntos.text ="Monedas:0" + puntos.ToString();
        if(puntos<0)
        {
            puntos= 0;
        }
    }

}
