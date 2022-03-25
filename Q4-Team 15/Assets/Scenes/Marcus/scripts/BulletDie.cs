using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDie : MonoBehaviour
{
    private GameObject Target;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Target = collision.gameObject;
        Target.GetComponent<Soldiers>().UnitHealth -= 10;
        Destroy(this.gameObject);
    }
}
