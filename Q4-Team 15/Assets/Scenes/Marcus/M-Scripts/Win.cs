using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject baSe;
    public GameObject H;

    // Start is called before the first frame update
    void Start()
    {
        H = GetComponent<Soldiers>().UnitHealth;

        baSe = GameObject.FindGameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (H <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
