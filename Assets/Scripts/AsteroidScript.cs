using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroidScript : MonoBehaviour
{
    public float speed;

    private int AsteroidLife = 5;

    public string SceneName;

    void Start()
    {

    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        if (AsteroidLife <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        //lasers disappear
        LaserScript LS = collision.gameObject.GetComponent<LaserScript>();

        if (LS)
        {
            AsteroidLife--;
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Asteroids hit wall
        Wallscript WS = collision.gameObject.GetComponent<Wallscript>();

        if (WS)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
