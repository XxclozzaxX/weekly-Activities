using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekOneRecap : MonoBehaviour
{
    // #Region to start a region and add a name of whats included
    // #endregion to end the region, it then can be collapsed
    #region my Awesome Variables
    public int myInt;  // an example of an int
    /// <summary>
	/// the users name as a string
	/// </summary>
    public string myName = "chloe"; 
    public float myHeight = 1.73f; // example of a float
    /*
     * a string to hold the users last name
     */
    public string myLastName = "buckley";
    public bool myBool = false; // example of a bool
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // this tempoary variable only exists inside the function its created in
        // can't access outside of this function
        // this can be used for any data type

        string myFavoriteGame = myName + "my faveGame is " + "child of light";

        // these are examples of Debug.Log and Debug.LogError
        // the LogError will pause the editor if it is enabled in the colsole
        Debug.Log("this is logging out: " + myName + " " + myLastName);
        Debug.LogError("theres an error here!");
        Debug.Log(myFavoriteGame);


        // this will return whole numbers, does not include 20
        // the returned number will be between 0-19 because it's a int
        myInt = Random.Range(0, 20);
        // this will return decimal numbers, includes up to 10
        // the returned number will be betweek 0-10 because it's a float
        myHeight = Random.Range(0f, 10f);

    }
}
