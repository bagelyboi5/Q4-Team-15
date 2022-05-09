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
    public bool isActive;

    public GameObject Cam;
    public Animator Anim;
    public Component TutCont;

    private void Start()
    {
        isActive = true;
        Cam = GameObject.Find("Main Camera");
        Anim = Cam.GetComponent<Animator>();
        TutCont = Cam.GetComponent<CameraTutorialCutscene>();
        sizeoftext = TextForTutorial.Length;
    }
    
    public void Update()
    {
        if (isActive == true)
        {
            if (Textnumber > 0)
            {
                Button2.SetActive(true);
            }

            if (Textnumber < 5)
            {
                Button1.SetActive(true);
            }

            if (Textnumber >= 5)
            {
                Button2.SetActive(false);
            }

            if (Textnumber <= 0)
            {
                Button1.SetActive(false);
            }
        }

        TutorialBox.text = TextForTutorial[Textnumber];
    }
    public void NextText()
    {
        if (Textnumber < sizeoftext)
        {
            Textnumber++;
        }
    }
    public void BackText()
    {
        if (Textnumber > 0)
        {
            Textnumber--;
        }
    }
    public void CloseTutorial()
    {
        TutorialBox.enabled = false;
        Button1.SetActive(false);
        Button2.SetActive(false);
        Closebutton.SetActive(false);
        Openbutton.SetActive(true);
        Anim.enabled = false;
        isActive = false;
        Cam.transform.position = new Vector3(0, 9.1f, -10);
        Cam.GetComponent<CameraTutorialCutscene>().enabled = false;
        Cam.GetComponent<CameraMovement>().enabled = true;

    }
    public void OpenTutorial()
    {
        TutorialBox.enabled = true;
        Button1.SetActive(true);
        Button2.SetActive(true);
        Closebutton.SetActive(true);
        Openbutton.SetActive(false);
        Anim.enabled = true;
        isActive = true;
        Cam.transform.position = new Vector2(0, 0);
        Cam.GetComponent<CameraTutorialCutscene>().enabled = true;
    }
}
