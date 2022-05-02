using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public int EDamage;
    public bool Enemey;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Enemey == false || collision.gameObject.tag == "Enemey")
        {
            collision.gameObject.GetComponent<Soldiers>().UnitHealth -= EDamage;
        }
        else
        {
            if (Enemey == true || collision.gameObject.tag == "Player")
            {
                collision.gameObject.GetComponent<Soldiers>().UnitHealth -= EDamage;
            }
        }
    }
}
