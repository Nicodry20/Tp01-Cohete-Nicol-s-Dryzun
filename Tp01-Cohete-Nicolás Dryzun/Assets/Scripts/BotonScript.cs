using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        Invoke(nameof(LaunchGameScene), 2.5f);
    }
    private void OnMouseUp()
    {
        //Debug.Log("Realese");
        botonNormalGO.SetActive(true);
        botonPresionadoGO.SetActive(false);
    }

    void LaunchGameScene()
    {
        SceneManager.LoadScene("Escena Juego");
    }
}
