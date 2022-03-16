using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMine : MonoBehaviour
{
    public GameObject Mine;
    public GameObject Barracks;
    public void BuildAMine()
    {
        Instantiate(Mine);
    }
    public void BuildBarracks()
    {
        Instantiate(Barracks);
    }
}
