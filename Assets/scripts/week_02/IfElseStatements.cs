using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseStatements : MonoBehaviour
{
    public string myName = "Chloe"; // users name
    public string myCarColour = "Black"; // car colour
    public bool likesCoffee = true; // coffee preferance
    public int myAge = 19; // usres age

    // Start is called before the first frame update
    void Start()
    {
        //if my name is equal to chloe do this
        if (myName == "Chloe")
        {
            Debug.Log("you are chloe");
        }
        // if my name is not equal to chloe do this
        else
        {
            Debug.Log("you are not chloe");
        }

        if(myAge < 19 && myAge < 5)
        {
            Debug.Log("your age is between 19 & 5");
        }
        else
        {
            Debug.Log("your age isnt between 19 & 5");
        }

        if(myAge > 5)
        {
            Debug.Log("age is greater than 5");
        }
        if(myAge < 29)
        {
            Debug.Log("age is less than 19");
        }

        if (myName != "Chloe" || myCarColour == "black")
        {
            Debug.Log("not chloe or car colour is black");
            if(likesCoffee == true)
            {
                Debug.Log("likes coffee");
            }
            else
            {
                Debug.Log("does not like coffee");
                if(myAge > 19)
                {
                    Debug.Log("your older than 19");
                }
                else
                {
                    Debug.Log("your younger than 19 :0");
                }
            }
        }
    }
}
