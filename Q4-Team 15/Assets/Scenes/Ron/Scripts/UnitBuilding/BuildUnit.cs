using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUnit : MonoBehaviour
{
    public GameObject soldier;
    public GameObject ATsoldier;
    public GameObject Tank;
    public GameObject ICBF;
    public Text CenterscreenText;
    public AudioClip []Buildtank;
    public AudioClip []BuildSoldiersound;

    public AudioClip []BuildICBF;
    public AudioSource Sourceofaudio;
    public int audioCounter;
    private void Update()
    {
        if(audioCounter >= 3 )
        {
            audioCounter = 0;
        }
    }
    public void BuildSoldier()
    {
        if(GameObject.Find("Player").GetComponent<PlayerManager>().Money >= 100f)
        {
            GameObject.Find("Player").GetComponent<PlayerManager>().Money -= 100f;
            Instantiate(soldier, GameObject.Find("Red Base").transform.position, Quaternion.identity, null);
            Sourceofaudio.clip = BuildSoldiersound[audioCounter];
            Sourceofaudio.Play();
            audioCounter++;
            gameObject.GetComponent<PlayerManager>().SoldierCount++;
        } else
        {
            StartCoroutine(YouHaveNoMOney());
        }
        
    }
    public void BuildATsoldier()
    {
        if (GameObject.Find("Player").GetComponent<PlayerManager>().Money >= 350f)
        {
            GameObject.Find("Player").GetComponent<PlayerManager>().Money -= 350f;
            Instantiate(ATsoldier, GameObject.Find("Red Base").transform.position, Quaternion.identity, null);
            Sourceofaudio.clip = BuildSoldiersound[audioCounter];
            Sourceofaudio.Play();
            audioCounter++;
            gameObject.GetComponent<PlayerManager>().AntiTankSoldier++;

        }
        else
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
            Sourceofaudio.clip = Buildtank[audioCounter];
            Sourceofaudio.Play();
            audioCounter++;
            gameObject.GetComponent<PlayerManager>().TankCount++;

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
            Sourceofaudio.clip = BuildICBF[audioCounter];
            Sourceofaudio.Play();
            audioCounter++;
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
