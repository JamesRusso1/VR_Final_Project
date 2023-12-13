using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public float speed;

    public float destructtime;

    void Update()
    {
        //movement irregular direction bc rotation of spawners
        transform.position += transform.up * speed * Time.deltaTime;

        //auto delete to prevent lag
        destructtime -= Time.deltaTime;
        if(destructtime <= 0)
        {
            Destroy(gameObject);
        }

    }
}
