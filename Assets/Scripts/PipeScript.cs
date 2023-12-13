using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeScript : MonoBehaviour
{
    private int score = 0;
    public string SceneName;
    private float TimeLeft = 75;

    public AudioSource Clank;

    void Start()
    {
     
    }


    void Update()
    {
        TimeLeft -= Time.deltaTime;

        if (score == 3 && TimeLeft <= 0)
        {
            SceneManager.LoadScene(SceneName);
        }
    }

    public void PipeScore()
    {
        score++;
        Clank.Play();
    }
}
