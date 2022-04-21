using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    public float BuildTime;
    public bool DoneBuilding;
    public bool Building;
    public bool BluePrintMode;
    public bool CanBuild;
    public GameObject Player;
    private Vector2 mouse;

    public void Start()
    {
        Player = GameObject.Find("Player");
        BluePrintMode = true;
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
        //Building the Mine
        if(Building == true)
        {
            StartCoroutine(BuildingMine());
        }
        if(DoneBuilding == true)
        {
                Player.GetComponent<PlayerManager>().Money += 10 * Time.deltaTime;

        }

    }

    IEnumerator BuildingMine()
    {
        yield return new WaitForSeconds(10);
        DoneBuilding = true;
        Building = false;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ore")
        {
            Building = true;
            BluePrintMode = false;
            Destroy(collision.gameObject);
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
        }
    }

}
