using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public int MovementSpeed;
    public int MovementSpeedBase;
    public int MovementSpeedFast;

    private void Start()
    {
        MovementSpeed = MovementSpeedBase;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            MovementSpeed = MovementSpeedBase;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            MovementSpeed = MovementSpeedFast;
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * MovementSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * MovementSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * MovementSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * MovementSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
            }
        }
    }
}
