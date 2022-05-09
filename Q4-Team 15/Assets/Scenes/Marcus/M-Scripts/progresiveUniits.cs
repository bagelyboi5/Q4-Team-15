using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progresiveUniits : MonoBehaviour
{
    private GameObject player;
    private PlayerManager PManager;
    public int SolKilled;
    public int TankKilled;

    void Start()
    {
        player = this.gameObject;
        PManager = player.GetComponent<PlayerManager>();
    }

    void Update()
    {
        if (SolKilled >= 20)
        {
            PManager.barracksUnits1.SetActive(true);
        }
        if (TankKilled >= 5)
        {
            PManager.barracksUnits2.SetActive(true);
        }
    }
}
