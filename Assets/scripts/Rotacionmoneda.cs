using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionmoneda : MonoBehaviour
    
{
    [SerializeField]
    float rotacionZ = 10f;
    void Update()
    {
        transform.Rotate(0f,0f,rotacionZ * Time.deltaTime);

    }
}
