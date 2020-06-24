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
        if(likesCoffee == true)
        {
            Debug.Log("Chloe Likes coffee");
        }
    }
}
