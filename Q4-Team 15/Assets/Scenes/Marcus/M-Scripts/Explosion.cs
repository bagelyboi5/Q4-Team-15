using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemey" || collision.gameObject.GetComponent<Soldiers>().Armor == false)
        {
            collision.gameObject.GetComponent<Soldiers>().UnitHealth -= 500;
        }
    }
}