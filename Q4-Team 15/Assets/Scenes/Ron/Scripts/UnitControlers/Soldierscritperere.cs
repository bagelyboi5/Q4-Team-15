using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldierscritperere : MonoBehaviour
{
    public bool IsSelected;
    public Vector3 GoToPosition;
    public GameObject MoveToCammand;
    public float Speed;

    public void Start()
    {
        GoToPosition = GameObject.Find("Player").GetComponent<PlayerManager>().PlayerBase.transform.position;
    }

    public void OnMouseDown()
    {

        if(IsSelected == false)
        {
            IsSelected = true;
        }   
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsSelected = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            IsSelected = false;
            GoToPosition.x = Input.mousePosition.x + Random.Range(-250,250);
            GoToPosition.y = Input.mousePosition.y + Random.Range(-250, 250);
            GoToPosition = Camera.main.ScreenToWorldPoint(GoToPosition);
            GoToPosition.z = 0;
        }
        if (IsSelected == true)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector2 direction = new Vector2(
                mousePosition.x - transform.position.x,
                mousePosition.y - transform.position.y
            );
            transform.up = direction;
            if (Input.GetKeyUp(KeyCode.Mouse1))
            {
                GoToPosition.x = Input.mousePosition.x + Random.Range(-50, 50);
                GoToPosition.y = Input.mousePosition.y + Random.Range(-50, 50);
                GoToPosition = Camera.main.ScreenToWorldPoint(GoToPosition);
                GoToPosition.z = 0;
                IsSelected = false;

            }
        }
        if ( IsSelected == false)
        {
            MoveToCammand.transform.position = GoToPosition;
            GetComponent<Pathfinding.AIDestinationSetter>().target = MoveToCammand.transform;
        }

    }
}
