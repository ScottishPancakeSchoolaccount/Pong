using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    //making variables to move the paddle
    public float speed = 4f;  //public float limit = 3.5f; 
    public string leftOrRight;
    public float maxValue = 3.8f;

    void paddleControl(KeyCode up,KeyCode down)
    {
        // Update is called once per frame
        if (Input.GetKey(up) && transform.position.y < maxValue) //max value is the max hight it can go
        {
            Debug.Log("Mega W key -Pancake");
            transform.Translate(Vector3.up * speed * Time.deltaTime); //movement up
        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue)
        {
            Debug.Log("the S key bruddah");
            transform.Translate(Vector3.down * speed * Time.deltaTime); //movement down

        }

    }
    void Update()
    {
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S);
        } else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}


