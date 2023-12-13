using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class PedestalScript : MonoBehaviour
{
    public Image EnergyBar;
    public GameObject EnergyCore;

    public string SceneName;

    public GameObject RightSpawner;
    public GameObject LeftSpawner;

    public AudioSource Energize;

    void Start()
    {
        EnergyBar.fillAmount = 1;
    }


    void Update()
    {
        //countdown
        EnergyBar.fillAmount -= Time.deltaTime * 0.03f;

        //toggle laser spawners
        if(EnergyBar.fillAmount >= 0)
        {
            RightSpawner.SetActive(true);
            LeftSpawner.SetActive(true);
        }

        if(EnergyBar.fillAmount <= 0)
        {
            //Lose
            SceneManager.LoadScene(SceneName);
            //RightSpawner.SetActive(false);
            //LeftSpawner.SetActive(false);
        }
    }

    public void AddTime()
    {
        EnergyBar.fillAmount = 1;

        Instantiate(EnergyCore, new Vector3(0.257f, 0.274f, 4.87f), transform.rotation);

        Energize.Play();
    }

    //selectexiteventargs parameter allows us to access the thing that is in the socket
    public void ReplaceEnergy(SelectExitEventArgs arg)
    {
        //destroy object in socket as it is removed
        Destroy(arg.interactableObject.transform.gameObject);
    }
}
