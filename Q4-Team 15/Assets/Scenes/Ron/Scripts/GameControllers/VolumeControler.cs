using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControler : MonoBehaviour
{
    public Slider volumeSliderControl;
    public GameObject Music, music1, music2;

    private void Start()
    {
        volumeSliderControl = gameObject.GetComponent<Slider>();
    }
    public void Update()
    {
        GameObject.Find("Audio Source").GetComponent<AudioSource>().volume = volumeSliderControl.value;
        Music.GetComponent<AudioSource>().volume = volumeSliderControl.value;
        music1.GetComponent<AudioSource>().volume = volumeSliderControl.value;
        music2.GetComponent<AudioSource>().volume = volumeSliderControl.value;
    }
}
