using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneToGame : MonoBehaviour
{
    public void ButtonMoveScene(string level)
    {
        SceneManager.LoadScene(level);
    }
}