using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public float H;

    void Start()
    {

    }

    void Update()
    {
        H = GetComponent<Soldiers>().UnitHealth;
        if (H <= 101)
        {
            SceneManager.LoadScene(2);
        }
    }
}
