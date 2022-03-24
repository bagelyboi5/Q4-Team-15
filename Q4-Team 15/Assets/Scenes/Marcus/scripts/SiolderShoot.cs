using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiolderShoot : MonoBehaviour
{
   
    private Rigidbody2D rb2;
    public GameObject Bullet;
    public GameObject FirePoint;
    public float bulletSpeed;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if((Input.GetButtonDown("Fire1") ||  Input.GetKeyDown(KeyCode.Space)))
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            rb2bullet.AddForce(bulletSpeed * transform.up);
            Destroy(b, 5);
        }
    }
}
