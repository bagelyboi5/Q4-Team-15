using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject Target;
    public GameObject Explosive;
    public bool Explosives;
    public bool Enemey;
    public bool AArmor;
    public int Damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Explosives == true)
        {
            Explosive.SetActive(true);
        }

        if (Enemey == false)
        {
            if (collision.gameObject.tag == "Enemey")
            {
                Target = collision.gameObject;
            }
            else
            {
                Destroy(gameObject);
            }

            if (AArmor == false)
            {
                if (Target.GetComponent<Soldiers>().Armor == false)
                {
                    Target.GetComponent<Soldiers>().UnitHealth -= Damage;
                }
                else
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                if (Target.GetComponent<Soldiers>().Armor == false)
                {
                    Target.GetComponent<Soldiers>().UnitHealth -= Damage;
                }
                else
                {
                    Target.GetComponent<Soldiers>().UnitHealth -= Damage;
                }
            }
        }
        else
        {
            if (collision.gameObject.tag == "Player")
            {
                Target = collision.gameObject;
            }
            else
            {
                Destroy(gameObject);
            }

            if (AArmor == false)
            {
                if (Target.GetComponent<Soldiers>().Armor == false)
                {
                    Target.GetComponent<Soldiers>().UnitHealth -= Damage;
                }
                else
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                if (Target.GetComponent<Soldiers>().Armor == false)
                {
                    Target.GetComponent<Soldiers>().UnitHealth -= Damage;
                }
                else
                {
                    Target.GetComponent<Soldiers>().UnitHealth -= Damage;
                }
            }
        }
    }
}
