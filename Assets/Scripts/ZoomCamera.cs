using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam;
    public float  defaultView;
    void Start()
    {
        cam=GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetButton("ZoomView"))
        {
            cam.fieldOfView = 40f;
        }
        else
        {
            cam.fieldOfView = defaultView;
        }

       
    }
}
