using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(LaunchRestart), 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LaunchRestart()
    {
        SceneManager.LoadScene("Escena Inicio");
    }
}
