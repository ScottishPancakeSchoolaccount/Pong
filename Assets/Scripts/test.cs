using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int summery;

    void bla(int num1, int num2)
    {
        summery = num1 + num2;
        Debug.Log(summery); 
    }

    void Start()
    {
        bla(1, 40);
        bla(0, 2);
    }
}
