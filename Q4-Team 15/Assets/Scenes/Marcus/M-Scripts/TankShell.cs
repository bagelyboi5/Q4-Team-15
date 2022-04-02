using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShell : MonoBehaviour
{
    public GameObject Explosion;
    private GameObject Target;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Target = collision.gameObject;
        if (Target.GetComponent<Soldiers>().Armor == true)
        {
            Explosion.SetActive(true);
            Target.GetComponent<Soldiers>().UnitHealth -= 100;
            Destroy(this.gameObject);
        }
        else
        {
            Explosion.SetActive(true);
            Target.GetComponent<Soldiers>().UnitHealth -= 100;
            Destroy(this.gameObject);
        }
    }
}