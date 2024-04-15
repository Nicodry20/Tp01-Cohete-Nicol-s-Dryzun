using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab2;
    public GameObject asteroidPrefab;
    public Vector3 newPosition;
    public float minX;
    public float maxX;
    public float interval;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneAsteroid), 0, interval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CloneAsteroid();
        }
    }

    public void CloneAsteroid()
    {
        float randomX = Random.Range(minX, maxX);
        newPosition = new Vector3(randomX, newPosition.y);

        int randomPreFab = Random.Range(0, 2);
        if (randomPreFab == 0)
        {
        Instantiate(asteroidPrefab, newPosition, Quaternion.identity);

        }
        else
        {
        Instantiate(asteroidPrefab2, newPosition, Quaternion.identity);

        }
    }
}
