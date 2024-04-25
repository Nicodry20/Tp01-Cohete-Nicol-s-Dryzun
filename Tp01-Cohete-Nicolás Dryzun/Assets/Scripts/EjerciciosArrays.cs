using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosArrays : MonoBehaviour
{
    public float[] notas;
    float promedio;
    // Start is called before the first frame update
    void Start()
    {
        //Escribir el primer elemento del array
        //Escribir la cantidad de elementos del array
        //Escribir cada elemento del array
        //Escribir el promedio de los elementos del array
        //Escribir los elementos del array mayores que 9
        //Escribir los elementos del array en orden inverso

        Debug.Log(notas[0]);
        Debug.Log(notas.Length);

        for (int i = 0; i < notas.Length; i++)
        {
            Debug.Log(notas[i]);
            promedio += notas[i];
        }
        promedio /= notas.Length;
        Debug.Log(promedio);
        for (int i = notas.Length - 1; i >= 0; i--)
        {
            Debug.Log(notas[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
