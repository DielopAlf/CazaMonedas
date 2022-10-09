using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionmoneda : MonoBehaviour
    
{
    [SerializeField]
    float rotacionX = 10f;
    void Update()
    {
        transform.Rotate(rotacionX,0f,0f * Time.deltaTime);

    }
}
