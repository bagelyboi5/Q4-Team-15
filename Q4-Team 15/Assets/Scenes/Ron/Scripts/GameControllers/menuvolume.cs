using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuvolume : MonoBehaviour
{
    public Slider VolumeSliderControl2;
    private void Start()
    {
        VolumeSliderControl2 = gameObject.GetComponent<Slider>();
    }
    private void Update()
    {
        GameObject.Find("music").GetComponent<AudioSource>().volume = VolumeSliderControl2.value;
    }
}
