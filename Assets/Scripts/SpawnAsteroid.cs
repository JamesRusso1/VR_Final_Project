using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{

    public GameObject Asteroid;

    public float DelayTime;

    void Start()
    {
        
    }
  
    void Update()
    {
        DelayTime -= Time.deltaTime;

        if (DelayTime <= 0)
        {
            Instantiate(Asteroid, new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(0,1), -50f), transform.rotation);

            DelayTime = 12;
        }
    }
}
