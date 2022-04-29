using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Soldiers : MonoBehaviour
{
    public GameObject Enemey;
    public GameObject PLayer;
    public Vector2 currentUnit;
    public float ToClosestEnemy;
    public bool IsEnemey;
    public float closestDistance;
    private Rigidbody2D rb2;
    public GameObject Bullet;
    public GameObject FirePoint;
    public float bulletSpeed;
    public float FireRate;
    public float UnitHealth;
    public bool canfire;
    public GameObject EnemyBase;
    private bool IsAlive = true;
    public bool Armor;
    public bool Base;




    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        EnemyBase = GameObject.Find("BlueBase");
    }
    public void Update()
    {
        if (UnitHealth <= 0)
        {
                EnemyBase.GetComponent<EnemyRespawnScript>().UnitThatDied = gameObject;
                EnemyBase.GetComponent<EnemyRespawnScript>().UnitDied();
        }
        //Targeting BS
        currentUnit.x = transform.position.x;
        currentUnit.y = transform.position.y;
        if (IsEnemey == false)
        {
            var high = 5f;
            closestDistance = high;

            foreach (GameObject e in GameObject.FindGameObjectsWithTag("Enemey"))  //Player stuff
            {
                float Distance = Vector2.Distance(e.transform.position, currentUnit);

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
            if (Enemey != null)
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
        }
        else
        {   //Enemy Stuff
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
        //Is the enemy
        if (IsEnemey == true)
        {
            Vector2 dir = new Vector2(PLayer.transform.position.x - transform.position.x,
                               PLayer.transform.position.y - transform.position.y);
            gameObject.transform.up = dir;
            if(canfire == true)
            {
                StartCoroutine(Shoot());
            }

        }
        //IS the friendly unit
        if (IsEnemey == false)
        {

            Vector2 dir = new Vector2(Enemey.transform.position.x - transform.position.x,
                               Enemey.transform.position.y - transform.position.y);
            gameObject.transform.up = dir;
            if(canfire == true)
            {
                StartCoroutine(Shoot());
            }
        }
    }
    public IEnumerator Shoot()
    {
        canfire = false;
        GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
        Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
        rb2bullet.AddForce(bulletSpeed * transform.up);
        Destroy(b, 5);
        yield return new WaitForSeconds(FireRate);
        canfire = true;
    }
}
