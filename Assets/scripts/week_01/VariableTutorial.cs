using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// a script that demonstrates the different variables inside unity
/// </summary>

public class VariableTutorial : MonoBehaviour
{
    ///access type, data type, variableName, default value
    ///the value of enerything will be seen as it is in the inspector
    ///and not the script
    
    public int myFirstInt = 1; // stores whole numbers
    private int m_mySecondInt = 4; // doesn't show up in the inspector
    public float myFirstFloat = 3.455f; // used to store decimal numbers (8)
    public double myFirstDouble = 0.11f; // used to store decimal numbers (16)
    public bool myFirstBool = false; // used to store a true or false value
    public string myFirstString = "Chloe is amazing"; // used to hold words
    public char myFirstChar = 'C'; // used to hold a single character

    // Start is called before the first frame update
    void Start()
    {
        myFirstString = "Chloe is not awesome"; // sets my first string to
        //chloe is not awesome

        myFirstInt = 5; // sets my first int to 5
    }

}
