using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{
    public int Basehealths;
    public void Update()
    {
        if(Basehealths <= 0)
        {
            EndGame();
        }
    }
   public void EndGame()
    {
        Debug.Log("you win");
    }
}
