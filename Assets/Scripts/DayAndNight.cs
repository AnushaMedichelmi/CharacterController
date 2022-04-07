using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNight : MonoBehaviour
{
    // Start is called before the first frame update

    float minPerSecond = 60f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angleTheFrame = (Time.deltaTime/1)*minPerSecond;
        transform.RotateAround(transform.position, Vector3.forward,angleTheFrame);
    }
}
