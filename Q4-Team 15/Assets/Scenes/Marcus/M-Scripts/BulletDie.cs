using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject Target;
    public int Damage;
    public bool AArmor;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemey")
        {
            Target = collision.gameObject;
        }
        else
        {
            Destroy(gameObject);
        }

        if (Target.GetComponent<Soldiers>().Armor == true || AArmor == true)
        {
            Target.GetComponent<Soldiers>().UnitHealth -= Damage;
            Target.GetComponent<BaseHealth>().Basehealths -= Damage;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
