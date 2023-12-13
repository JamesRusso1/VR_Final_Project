using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Laser;
    public Image EnergyBar;

    public AudioSource Beam;

    public InputActionProperty actionInput;

    void OnEnable()
    {
      actionInput.action.started += SpawnLaser;
        
    }

    private void SpawnLaser(InputAction.CallbackContext obj)
    {
        //spawn lasers
        Instantiate(Laser, transform.position, transform.rotation);

        Beam.Play();
    }
}
