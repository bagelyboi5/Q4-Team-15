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
        } else
        {
            IsSelected = false;
        }
    }

    void Update()
    {
        if (IsSelected == true) {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Vector2 direction = new Vector2(
                mousePosition.x - transform.position.x,
                mousePosition.y - transform.position.y
            );

            transform.up = direction;
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                GoToPosition.x = Input.mousePosition.x;
                GoToPosition.y = Input.mousePosition.y;
                GoToPosition = Camera.main.ScreenToWorldPoint(GoToPosition);
                GoToPosition.z = 0;
                IsSelected = false;

            }
        }
        if( IsSelected == false)
        {
            MoveToCammand.transform.position = GoToPosition; 
        }
        gameObject.transform.position = (Vector2.MoveTowards(transform.position, MoveToCammand.transform.position, Speed * Time.deltaTime));

    }
}
