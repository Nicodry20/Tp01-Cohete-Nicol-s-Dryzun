using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteScript : MonoBehaviour
{
    public float speed;
    public GameObject fuego; // Objeto de fuego

    private bool coheteDespegado = false; // Variable para controlar si el cohete ha despegado

    // Start is called before the first frame update
    void Start()
    {
        fuego.SetActive(false); // Desactivar el fuego al inicio
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed, 0);

        // Activar el fuego cuando el cohete despega
        if (!coheteDespegado && speed > 0)
        {
            fuego.SetActive(true);
            coheteDespegado = true;
        }
    }
}
