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
}
