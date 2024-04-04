using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteScript : MonoBehaviour
{
    public float speed;
    public GameObject fuego;

    private bool coheteDespegado = false;

    // Start is called before the first frame update
    void Start()
    {
        fuego.SetActive(false);
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
