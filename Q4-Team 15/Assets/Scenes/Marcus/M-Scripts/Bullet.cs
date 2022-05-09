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
    private Animator Anim;

    void start()
    {
        Anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
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
                    Destroy(gameObject);
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
                    Destroy(gameObject);
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
                    Destroy(gameObject);
                }
                else
                {
                    Target.GetComponent<Soldiers>().UnitHealth -= Damage;
                    Destroy(gameObject);
                }
            }
        }
        if (Explosives == true)
        {
            Explosive.SetActive(true);
            Anim.SetBool("impact", true);
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

        }
        else
        {
            Anim.SetBool("impact", false);
        }
    }
}
