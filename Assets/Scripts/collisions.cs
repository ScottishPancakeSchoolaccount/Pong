using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public float xPosition = 1f;
    public float yPosition = 1f;
    public float xSpeed = 10f;
    public float ySpeed = 10f;
    public TMP_Text scoreField;
    public int leftScore = 0;
    public int rightScore = 0;
    public int topScore = 5; 

    //function
    void resetBall()
    {
        xPosition = 0f;
        yPosition = Random.Range(-4f, 4f);
        xSpeed = 2f;
        ySpeed = 2f;
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime;
        //xPosition += xSpeed * Time.deltaTime; shorter way to do the same thing 
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
        if(leftScore >= 5)
        {
            scoreField.text = "Left player has won!";
            xPosition = 0f;
            yPosition = 0f;
        }
        else if(rightScore >= 5)
        {
            scoreField.text = "Right player has won!";
            xPosition = 0f;
            yPosition = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horrizontalWall"))
        {
            ySpeed = ySpeed * -1f;
        }
       // else if (collision.gameObject.CompareTag("verticalWall"))
      //  {
      //      xSpeed = xSpeed * -1f;
     //   }
        else if (collision.gameObject.CompareTag("verticalWallLeft"))
        {
           resetBall();
            rightScore++;
            scoreField.text = leftScore + " - " + rightScore;
        }
        else if (collision.gameObject.CompareTag("verticalWallRight"))
        {
            resetBall();
            leftScore++;
            scoreField.text = leftScore + " - " + rightScore;
        }
        else if  (collision.gameObject.CompareTag("player"))
        {
            xSpeed = xSpeed * -1.1f;
        }
        else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1.1f;
        }
    }
}
