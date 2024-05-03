using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroidCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Invoke(nameof(LaunchInicialScene), 2);
        }
        else if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }

    void LaunchInicialScene()
    {
        SceneManager.LoadScene("Game Over");
    }
}
