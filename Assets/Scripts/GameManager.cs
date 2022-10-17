using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CarControllerRefactored ccr;
    public GameObject needle;
    private float startPos = 220;
    private float endPos = -41;
    private float desiredPos;

    public float vehicleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vehicleSpeed = ccr.KPH;
        updateNeedle();
    }

    private void updateNeedle()
    {
        desiredPos = startPos - endPos;
        float temp = vehicleSpeed / 180;
        needle.transform.eulerAngles = new Vector3(0, 0, (startPos - temp * desiredPos));
    }
}
