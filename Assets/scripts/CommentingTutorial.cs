using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommentingTutorial : MonoBehaviour
{

    //this is a single line comment

    /// <summary>
    /// this is my first bool
    /// </summary>
   [Tooltip("a bool used for my first")] //this will show what the function does int the inspector
    public bool myFirstBool = true;

    [Header("player name")] //puts a heading on top of the inspector function
    public string myFirstString = "somestring";

    [Space(5)] //puts a space inside the inspector
    public int myFirstInt = 1;

    /*this is a multi line comment
     * when i press enter i get a new line, alother slash end the lines
     */

    #region functions - holds all of the functions in my game


    /// <summary>
    /// this is a start function, it is called on the first frame of the game
    /// </summary>
    void Start()
    {
        myFirstBool = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion
}
