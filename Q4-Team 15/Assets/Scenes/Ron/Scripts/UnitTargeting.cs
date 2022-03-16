using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitTargeting : MonoBehaviour
{
    public GameObject Enemey;
    public GameObject PLayer;
    public Vector2 currentUnit;
    public float ToClosestEnemy;
    public bool IsEnemey;
    public GameObject bullet;
    public float closestDistance;

    public void Update()
    {
        currentUnit.x = transform.position.x;
        currentUnit.y = transform.position.y;
        if (IsEnemey == false)
        {
            var high = 5f;
            closestDistance = high;

            foreach (GameObject e in GameObject.FindGameObjectsWithTag("Enemey"))  //Player stuff
            {
                float  Distance = Vector2.Distance(e.transform.position, currentUnit);
                Debug.Log(e.gameObject.name + " " + Distance + " " + closestDistance);

                if (Distance < high)
                {

                    //Find the closest enemy and make it the target...
                   
                    if (Distance < closestDistance)
                    {
                        closestDistance = Distance;
                        Enemey = e;
                    }

                }
            }
            if(Enemey != null)
            {
                if (Vector3.Distance(Enemey.transform.position, gameObject.transform.position) > 5f)
                {
                    Enemey = null;
                }
                else
                {
                    Aim();
                }
            }
        } else {   //Enemy Stuff
            var high = 5f;
            foreach (GameObject r in GameObject.FindGameObjectsWithTag("Player"))
            {
                var Distance = Vector2.Distance(r.transform.position, currentUnit);
                if (Distance < high)
                {
                    PLayer = r;
                }
            }
            if (PLayer != null) 
            {
                if (Vector3.Distance(PLayer.transform.position, gameObject.transform.position) > 5f)
                {
                    PLayer = null;
                }
                else
                {
                    Aim();
                }
            }
        }

    }
    public void Aim()
    {
        if (IsEnemey == true)
        {
            Vector2 dir = new Vector2(PLayer.transform.position.x - transform.position.x,
                               PLayer.transform.position.y - transform.position.y);
            gameObject.transform.up = dir;
            Destroy(PLayer);
        }
        if (IsEnemey == false)
        {
            Vector2 dir = new Vector2(Enemey.transform.position.x - transform.position.x,
                               Enemey.transform.position.y - transform.position.y);
            gameObject.transform.up = dir;
            Destroy(Enemey);
        }
    }
}
