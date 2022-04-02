using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiArmorBullet : MonoBehaviour
{
    private GameObject Target;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Target = collision.gameObject;
        if (Target.GetComponent<Soldiers>().Armor == true)
        {
            Target.GetComponent<Soldiers>().UnitHealth -= 10;
            Destroy(this.gameObject);
        }
        else
        {
            Target.GetComponent<Soldiers>().UnitHealth -= 10;
            Destroy(this.gameObject);
        }
    }
}