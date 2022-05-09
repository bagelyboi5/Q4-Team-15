using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progresiveUniits : MonoBehaviour
{
    private GameObject player;
    private PlayerManager PManager;
    public int SolKilled;
    public int TankKilled;
    private GameObject BarracksBuilding;
    public bool Barracks;
    public AudioClip Phase1;
    public AudioClip Phase2;
    public AudioClip Phase3;

    void Start()
    {
        player = this.gameObject;
        PManager = player.GetComponent<PlayerManager>();
    }

    void Update()
    {
        BarracksBuilding = GameObject.Find("BArracks(Clone)");
        if (BarracksBuilding.GetComponent<BarracksScript>().IsBuilt == true)
        {
            PManager.barracksUnits0.SetActive(true);
        }
        if (SolKilled >= 20)
        {
            GameObject.Find("Music").GetComponent<AudioSource>().clip = Phase2;
            GameObject.Find("Music").GetComponent<AudioSource>().Play();
            PManager.barracksUnits1.SetActive(true);
        }
        if (TankKilled >= 5)
        {
            GameObject.Find("Music").GetComponent<AudioSource>().clip = Phase3;
            GameObject.Find("Music").GetComponent<AudioSource>().Play();
            PManager.barracksUnits2.SetActive(true);
        }
    }
}
