using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesTeclado : MonoBehaviour
{
    public float movX;
    public float speed;
    public float maxX = 8;
    public float minX = -8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        transform.Translate(movX * speed * Time.deltaTime, 0, 0);

        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX,transform.position.y, transform.position.z);
        }
        else if (transform.position.x < minX)
        {

        }
    }
}
