using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreBoard : MonoBehaviour
{
    public float leftScore;
    public float rightScore;
    public string leftscoreOrRightscore;

    // Update is called once per frame
    void Update()
    { 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "verticalWallRight")
        {
            Debug.Log("hit the right wall");
            leftScore++;
            Debug.Log(leftScore);
        }
        else if (collision.gameObject.name == "verticalWallLeft")
        {
            Debug.Log("hit the left wall");
            rightScore++;
            Debug.Log(rightScore);

        }
    }
}
