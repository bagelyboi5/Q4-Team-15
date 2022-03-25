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
        CountdownTimer -= 1 * Time.deltaTime;
        CountDown.text = "" + CountdownTimer;
        CountDown.text.Trim();
    }
    public void Start()
    {
        TextTimer = GameObject.Find("Timer");
        TextTimer.SetActive(true);
        CountDown = TextTimer.GetComponent<Text>();
    }
}
