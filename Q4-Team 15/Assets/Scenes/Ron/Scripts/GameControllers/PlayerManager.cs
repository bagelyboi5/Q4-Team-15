using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float Money;
    public float Power;
    public int SoldierCount;
    public int TankCount;
    public int planeCount;
    public GameObject MoneyTezt;
    public GameObject barracksUnits;
    public GameObject PlayerBase;
    public GameObject ClosestBarracks;
    public float DistanceToBarracks;
    public GameObject BombButton;



    public void Start()
    {
        MoneyTezt = GameObject.Find("MoneyText");
    }
    public void Update()
    {
        MoneyTezt.GetComponent<Text>().text = "Money: " + Money;
        if(GameObject.Find("BArracks(Clone)") != null)
        {
        DistanceToBarracks = Vector3.Distance(GameObject.Find("BArracks(Clone)").transform.position, PlayerBase.transform.position);
        }

    }
    public void OpenTopMenu()
    {
        barracksUnits.SetActive(true);
    }
    public void OpenTheBombDoor()
    {
        BombButton.SetActive(true);
    }
    public void BuildUnit()
    {
        float distance = Vector3.Distance(GameObject.Find("BArracks(Clone)").transform.position, PlayerBase.transform.position);
        if (distance < 5f)
        {
            if(Money > 100)
            {
                ClosestBarracks = GameObject.Find("BArracks(Clone)");
                ClosestBarracks.GetComponent<BuildUnit>().BuildSoldier();
            }
        }
        else
        {
            Debug.Log("Your barracks is to far away");
        }


        
    }

}
