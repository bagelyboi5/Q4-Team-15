using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUnit : MonoBehaviour
{
    public GameObject soldier;
    public GameObject Tank;
    public GameObject ICBF;
    public Text CenterscreenText;
    
    public void BuildSoldier()
    {
        if(GameObject.Find("Player").GetComponent<PlayerManager>().Money >= 100f)
        {
            GameObject.Find("Player").GetComponent<PlayerManager>().Money -= 100f;
            Instantiate(soldier, GameObject.Find("Red Base").transform.position, Quaternion.identity, null);
        } else
        {
            StartCoroutine(YouHaveNoMOney());
        }
        
    }
    public void BuildTank()
    {
        if (GameObject.Find("Player").GetComponent<PlayerManager>().Money >= 1000f)
        {
            GameObject.Find("Player").GetComponent<PlayerManager>().Money -= 1000f;
            Instantiate(Tank, GameObject.Find("Red Base").transform.position, Quaternion.identity, null);
        }
        else
        {
            StartCoroutine(YouHaveNoMOney());
        }
    }
    public void ImgoingtoEndGame()
    {
        if (GameObject.Find("Player").GetComponent<PlayerManager>().Money >= 10000f)
        {
            GameObject.Find("Player").GetComponent<PlayerManager>().Money -= 10000f;
            Instantiate(ICBF, GameObject.Find("Red Base").transform.position, Quaternion.identity, null);
        }
        else
        {
            StartCoroutine(YouHaveNoMOney());
        }
    }

  public  IEnumerator YouHaveNoMOney()
    {
        CenterscreenText.text = "You dont have enough money!";
        yield return new WaitForSeconds(2);
        CenterscreenText.text = " ";
    }
}
