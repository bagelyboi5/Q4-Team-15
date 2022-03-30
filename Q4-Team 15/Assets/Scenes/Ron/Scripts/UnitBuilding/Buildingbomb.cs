using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildingbomb : MonoBehaviour
{
    public int Cost;
    public bool IsBuilt;
    public bool BluePrintMode;
    public GameObject Player;
    public Vector2 mouse;
    public string Unit;

    public void Start()
    {
        Player = GameObject.Find("Player");
    }
    public void Update()
    {
        mouse.x = Input.mousePosition.x;
        mouse.y = Input.mousePosition.y;
        if (BluePrintMode == true)
        {
            mouse = Camera.main.ScreenToWorldPoint(mouse);
            //Goes to the mouse on mouse down
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                transform.position = mouse;
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                Destroy(gameObject);
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("BaseArea"))
        {
            if (Player.GetComponent<PlayerManager>().Money >= Cost)
            {
                BluePrintMode = false;
                IsBuilt = true;
                Player.GetComponent<PlayerManager>().OpenTheBombDoor();
                Player.GetComponent<PlayerManager>().Money -= Cost;
            }
        }
    }
}
