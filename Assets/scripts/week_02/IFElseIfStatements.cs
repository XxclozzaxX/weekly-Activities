using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFElseIfStatements : MonoBehaviour
{
    public string myName = "chloe";
    public string myCarColour = "Black";
    public bool likesCoffee = true;
    public int myAge = 19;

    // Start is called before the first frame update
    void Start()
    {
        if(likesCoffee == true)
        {
            Debug.Log("Likes Coffee");
        }

        if(myAge > 5)
        {
            Debug.Log("my age is greater than 5");
        }
        else
        {
            Debug.Log("my age is less than 5");
        }

        if(myAge > 19)
        {
            Debug.Log("my age is greater than 19");
        }
        else if(myAge < 16)
        {
            Debug.Log("my age is less than 16");
        }

        if(myCarColour == "black")
        {
            Debug.Log("my car is black");
        }
        else if(myCarColour == "yellow")
        {
            Debug.Log("my car is yellow");
            if(likesCoffee == false)
            {
                Debug.Log("don't like coffee");
            }
        }
        else
        {
            if(myCarColour == "purple")
            {
                Debug.Log("car colour is purple");
            }
            else
            {
                Debug.Log("my car is some other colour");
            }
        }
    }
}
