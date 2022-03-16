using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildUnit : MonoBehaviour
{
    public GameObject soldier;
    
    public void BuildSoldier()
    {
        GameObject.Find("Player").GetComponent<PlayerManager>().Money -= 100f;
        Instantiate(soldier,GameObject.Find("Red Base").transform.position,Quaternion.identity,null);
    }
}
