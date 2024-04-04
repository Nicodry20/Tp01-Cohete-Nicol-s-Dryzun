using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{
    public GameObject botonNormalGO;
    public GameObject botonPresionadoGO;
    public CoheteScript coheteScript;
    // Start is called before the first frame update
    void Start()
    {
        botonNormalGO.SetActive(true);
        botonPresionadoGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Debug.Log("Click");
        botonNormalGO.SetActive(false);
        botonPresionadoGO.SetActive(true);
        coheteScript.speed = 0.1f;
    }
    private void OnMouseUp()
    {
        //Debug.Log("Realese");
        botonNormalGO.SetActive(true);
        botonPresionadoGO.SetActive(false);
    }
}
