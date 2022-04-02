using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileExplosions : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.GetComponent<Soldiers>().Armor == false)
        {
            collision.gameObject.GetComponent<Soldiers>().UnitHealth -= 50;
        }
    }
}
