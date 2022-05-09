using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTutorialCutscene : MonoBehaviour
{

    public GameObject TutorialText;
    public TutorialScript TextNumberSync;
    public int AnimWindow;
    public int TutTextPart;
    public Animator CamAnim;

    void Start()
    {
        gameObject.GetComponent<CameraMovement>().enabled = false;
        TutorialText = GameObject.Find("TutorialText");
        TextNumberSync = TutorialText.GetComponent<TutorialScript>();
        CamAnim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        CamAnim.SetInteger("TutorialTextPart", AnimWindow);
        AnimWindow = TextNumberSync.Textnumber;
        
        if (AnimWindow >= 1)
        {
            gameObject.GetComponent<CameraMovement>().enabled = true;
        }
        if (AnimWindow >= 2)
        {
            gameObject.GetComponent<CameraMovement>().enabled = false;
        }
        if (AnimWindow <= 0)
        {
            gameObject.GetComponent<CameraMovement>().enabled = false;

        }
    }
}
