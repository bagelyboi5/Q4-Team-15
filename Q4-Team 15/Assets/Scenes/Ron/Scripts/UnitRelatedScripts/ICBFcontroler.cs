using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ICBFcontroler : MonoBehaviour
{
    public Text CountDown;
    public float CountdownTimer;
    private GameObject TextTimer;
    public void Update()
    {
        if(CountdownTimer >= 0f)
        {
            CountdownTimer -= 1 * Time.deltaTime;
        }
        if (CountdownTimer <= 0f)
        {
            CountdownTimer = 0f;
            foreach (GameObject T in GameObject.FindGameObjectsWithTag("Player"))
            {
                Destroy(T);
            }
            foreach (GameObject T in GameObject.FindGameObjectsWithTag("Enemey"))
            {
                Destroy(T);
            }

        }
        CountDown.text = " " + CountdownTimer;
    
    }
    public void Start()
    {
        TextTimer = GameObject.Find("Timer");
        TextTimer.SetActive(true);
        CountDown = TextTimer.GetComponent<Text>();
    }
}
