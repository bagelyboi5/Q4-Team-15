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
    public GameObject Phase1;
    public GameObject Phase2;
    public GameObject Phase3;

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
            PManager.barracksUnits1.SetActive(true);
        }
        if (TankKilled >= 5)
        {
            PManager.barracksUnits2.SetActive(true);
        }
        if (SolKilled >= 20 && TankKilled <= 5)
        {
            Phase2.SetActive(true);
            Phase1.SetActive(false);
        }
        if (SolKilled >= 20 && TankKilled >= 5)
        {
            Phase1.SetActive(false);
            Phase2.SetActive(false);
            Phase3.SetActive(true);
        }
    }
}
