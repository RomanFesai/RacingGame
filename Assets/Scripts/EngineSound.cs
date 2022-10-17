using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSound : MonoBehaviour
{
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;
    private float currentSpeed;

    [SerializeField] private float minPitch;
    [SerializeField] private float maxPitch;
    private float pitchFromCar;


    private Rigidbody carRb;
    private AudioSource engineAudio;

    void Start()
    {
        engineAudio = GetComponent<AudioSource>();
        carRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        CarSound();   
    }

    void CarSound()
    {
        currentSpeed = carRb.velocity.magnitude;
        pitchFromCar = carRb.velocity.magnitude / 50f;

        if(currentSpeed < minSpeed)
        {
            engineAudio.pitch = minPitch;
        }

        if(currentSpeed > minSpeed && currentSpeed < maxSpeed)
        {
            engineAudio.pitch = minPitch + pitchFromCar;
        }

        if (currentSpeed > maxSpeed)
        {
            engineAudio.pitch = maxPitch;
        }
    }
}
