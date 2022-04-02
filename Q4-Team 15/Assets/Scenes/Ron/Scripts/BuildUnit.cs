using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildUnit : MonoBehaviour
{
    public GameObject soldier;
    public GameObject AntiArmorSoldier;
    
    public void BuildSoldier()
    {
        if (GameObject.Find("Player").GetComponent<PlayerManager>().Money >= 100f)
        {
            GameObject.Find("Player").GetComponent<PlayerManager>().Money -= 100f;
            Instantiate(soldier, GameObject.Find("Red Base").transform.position, Quaternion.identity, null);
        }
    }
    public void BuildAntiArmorSoldier()
    {
        if (GameObject.Find("Player").GetComponent<PlayerManager>().Money >= 200f)
        {
            GameObject.Find("Player").GetComponent<PlayerManager>().Money -= 200f;
            Instantiate(AntiArmorSoldier, GameObject.Find("Red Base").transform.position, Quaternion.identity, null);
        }
    }

}
