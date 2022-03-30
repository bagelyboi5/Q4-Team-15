using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildUnit : MonoBehaviour
{
    public GameObject soldier;
    public GameObject ICBF;
    
    public void BuildSoldier()
    {
        if(GameObject.Find("Player").GetComponent<PlayerManager>().Money >= 100f)
        {
            GameObject.Find("Player").GetComponent<PlayerManager>().Money -= 100f;
            Instantiate(soldier, GameObject.Find("Red Base").transform.position, Quaternion.identity, null);
        }
    }
    public void ImgoingtoEndGame()
    {
        if (GameObject.Find("Player").GetComponent<PlayerManager>().Money >= 10000f)
        {
            GameObject.Find("Player").GetComponent<PlayerManager>().Money -= 10000f;
            Instantiate(ICBF, GameObject.Find("Red Base").transform.position, Quaternion.identity, null);
        }
    }
}
