using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameCamLimit : MonoBehaviour
{

    private float minX;
    private float minY;
    private float maxX;
    private float maxY;
    private GameObject Cam;
    public float CurrentX;
    public float CurrentY;

    void Start()
    {
        minX = -35.6f;
        minY = -120.36f;
        maxX = 26.26f;
        maxY = 11;
        Cam = gameObject;
    }

    void Update()
    {
        CurrentX = Cam.transform.position.x;
        CurrentY = Cam.transform.position.y;

        if (CurrentX >= maxX)
        {
            Cam.transform.position = new Vector3(maxX, CurrentY, -10);
        }
        if (CurrentX <= minX)
        {
            Cam.transform.position = new Vector3(minX, CurrentY, -10);
        }

        if (CurrentY >= maxY)
        {
            Cam.transform.position = new Vector3(CurrentX, maxY, -10);
        }
        if (CurrentY <= minY)
        {
            Cam.transform.position = new Vector3(CurrentX, minY, -10);
        }
    }
}
