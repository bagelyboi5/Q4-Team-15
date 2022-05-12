using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoom : MonoBehaviour
{

    private Camera Cam;
    private int Zoomy;
    private bool isMax;
    private bool isMin;

    void Start()
    {
        Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        Zoomy = 5;
    }

    void Update()
    {
        Cam.orthographicSize = Zoomy;

        if (Zoomy >= 10)
        {
            isMax = true;
        }
        else
        {
            isMax = false;
        }

        if (Zoomy <= 5)
        {
            isMin = true;
        }
        else
        {
            isMin = false;
        }

        if (isMax == false)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                Zoomy++;
            }
        }
        if (isMin == false)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                Zoomy--;
            }
        }
    }
}
