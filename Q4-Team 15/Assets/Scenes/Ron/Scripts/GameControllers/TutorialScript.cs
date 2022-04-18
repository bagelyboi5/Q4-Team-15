using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public Text TutorialBox;
    public int Textnumber;
    public int sizeoftext;
    [TextArea(4,4)]
    public string[] TextForTutorial;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Closebutton;
    public GameObject Openbutton;
    private void Start()
    {
        sizeoftext = TextForTutorial.Length;
    }

    public void Update()
    {
        if (Textnumber >= sizeoftext)
        {
            Textnumber = 0;
        }
        if (Textnumber <= -1)
        {
            Textnumber = sizeoftext;
        }
        TutorialBox.text = TextForTutorial[Textnumber];
    }
    public void NextText()
    {
        Textnumber++;
    }
    public void BackText()
    {
        Textnumber--;
    }
    public void CloseTutorial()
    {
        TutorialBox.enabled = false;
        Button1.SetActive(false);
        Button2.SetActive(false);
        Closebutton.SetActive(false);
        Openbutton.SetActive(true);
    }
    public void OpenTutorial()
    {
        TutorialBox.enabled = true;
        Button1.SetActive(true);
        Button2.SetActive(true);
        Closebutton.SetActive(true);
        Openbutton.SetActive(false);
    }
}
