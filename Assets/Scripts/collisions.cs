using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public float xPosition = 1f;
    public float yPosition = 1f;
    public float xSpeed = 10f;
    public float ySpeed = 10f;

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
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horrizontalWall"))
        {
            Debug.Log("Ouch my head!");
            ySpeed = ySpeed * -1f; 
        } 
        else if (collision.gameObject.CompareTag("verticalWall"))
        {
            Debug.Log("Ouch my butt!");
            xSpeed = xSpeed * -1f;
        }
    }
}
