using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniMap : MonoBehaviour
{
    public GameObject it;


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.M))
        {
            it.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            it.SetActive(true);
        }
    }
}
