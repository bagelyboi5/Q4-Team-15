using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDie : MonoBehaviour
{
    private GameObject Target;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Target = collision.gameObject;
        if (Target.GetComponent<Soldiers>().Armor == false)
        {
            Target.GetComponent<Soldiers>().UnitHealth -= 10;
            Target.GetComponent<BaseHealth>().Basehealths -= 5;
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
