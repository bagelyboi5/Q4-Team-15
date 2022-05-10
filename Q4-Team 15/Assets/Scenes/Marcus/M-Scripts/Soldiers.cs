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
    private GameObject cameraa;
    private Animator shake;
    public AudioClip Deathsound;
    private GameObject PlayerControll;
    private progresiveUniits PROG;
    public bool TankUnit;
    public AudioClip Shootsound;




    void Start()
    {
        PlayerControll = GameObject.Find("Player");
        PROG = PlayerControll.GetComponent<progresiveUniits>();
        cameraa = GameObject.Find("CameraParent");
        shake = cameraa.GetComponent<Animator>();
        rb2 = GetComponent<Rigidbody2D>();
        EnemyBase = GameObject.Find("BlueBase");
    }
    public void Update()
    {
        if (UnitHealth <= 0)
        {
            shake.SetBool("shakey", true);
            GameObject.Find("Audio Source").GetComponent<AudioSource>().clip = Deathsound;
            GameObject.Find("Audio Source").GetComponent<AudioSource>().Play();
            if (IsEnemey == true)
            {
                if (TankUnit == true)
                {
                    PROG.TankKilled++;
                    EnemyBase.GetComponent<EnemyRespawnScript>().UnitThatDied = gameObject;
                    EnemyBase.GetComponent<EnemyRespawnScript>().UnitDied();
                }
                else
                {
                    PROG.SolKilled++;
                    EnemyBase.GetComponent<EnemyRespawnScript>().UnitThatDied = gameObject;
                    EnemyBase.GetComponent<EnemyRespawnScript>().UnitDied();
                }
            }
            else
            {
                Destroy(gameObject);
            }
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
                GameObject.Find("Audio Source").GetComponent<AudioSource>().clip = Shootsound;
                GameObject.Find("Audio Source").GetComponent<AudioSource>().Play();
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
                GameObject.Find("Audio Source").GetComponent<AudioSource>().clip = Shootsound;
                GameObject.Find("Audio Source").GetComponent<AudioSource>().Play();
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
