using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float fallingSpeed;
    public float rotationSpeed;
    public float minScale;
    public float maxScale;
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.Range(-rotationSpeed, rotationSpeed);
        float newScale = Random.Range(minScale, maxScale);
        transform.localScale = new Vector3(newScale, newScale, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallingSpeed * Time.deltaTime, 0, Space.World);
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
