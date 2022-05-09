using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTut : MonoBehaviour
{
    public GameObject Cam;
    public Animator Anim;
    public Component TutCont;
    void Start()
    {
        Cam = GameObject.Find("Main Camera");
        Anim = Cam.GetComponent<Animator>();
        TutCont = Cam.GetComponent<CameraTutorialCutscene>();
    }

    void Update()
    {
        Debug.Log("dfegybh");
    }
}
