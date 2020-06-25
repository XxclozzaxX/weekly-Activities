using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementsTutorial : MonoBehaviour
{
    public string myName = "Chloe"; // my name as a string
    public bool likesCoffee = true; // my coffee preferance as a bool
    public int myFavouriteNumber = 17; // what my favourite number is
    public float myFavouriteFloat = 5.5f; // an example of a float

    // Start is called before the first frame update
    void Start()
    {
        // == is asking if the left equals the right
        // = is that the left gets the right
        if(likesCoffee == true)
        {
            Debug.Log("Chloe Likes coffee");
        }

        if(likesCoffee == false)
        {
            Debug.Log("chloe dislikes coffee");
        }
        // is equal to
        if(myName == "stacey")
        {
            Debug.Log("your name is stacey");
        }
        // != is not equal to
        if (myName != "stacey")
        {
            Debug.Log("your name is chloe");
            likesCoffee = false;
        }

        if(myFavouriteNumber == 17)
        {
            Debug.Log("is exactly 7");
        }

        if(myFavouriteNumber < 5)
        {
            Debug.Log("Your number is less than 5");
        }

        if(myFavouriteNumber > 5)
        {
            Debug.Log("your number is greater than 5");
        }
    }
}
