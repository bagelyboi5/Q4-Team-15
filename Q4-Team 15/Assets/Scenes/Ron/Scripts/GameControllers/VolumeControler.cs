using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControler : MonoBehaviour
{
    public Slider volumeSliderControl;

    private void Start()
    {
        volumeSliderControl = gameObject.GetComponent<Slider>();
    }
    public void Update()
    {
        GameObject.Find("Audio Source").GetComponent<AudioSource>().volume = volumeSliderControl.value;
        GameObject.Find("Music1").GetComponent<AudioSource>().volume = volumeSliderControl.value;
        GameObject.Find("Music2").GetComponent<AudioSource>().volume = volumeSliderControl.value;
        GameObject.Find("Music3").GetComponent<AudioSource>().volume = volumeSliderControl.value;
    }
}
