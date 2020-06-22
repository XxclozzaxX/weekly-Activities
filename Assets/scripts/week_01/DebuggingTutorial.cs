using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggingTutorial : MonoBehaviour
{

    public string myName = "chloe"; //a string to hold my name
    public int myAge = 19; //an int to hold my age
    public bool myFirstBool = false; // a bool to hold my bool
    public int myAgeInMonths = 0; //an int to hold my age in months

    // Start is called before the first frame update
    void Start()
    {
        /// debug.log message logs out the message that we put in it
		/// we can add multiple strings and variabls together to make
		/// one big string
		/// debugging is super useful when we want to break down the code
		/// to see where there occuring
        Debug.Log(myName);
        Debug.Log(myAge);
        Debug.Log(myFirstBool);
        Debug.Log(myAgeInMonths);
        //this is an example of adding strings and variables together
        Debug.Log(myName + " is this many years old " + myAge);

        myAgeInMonths = myAge * 12;
        Debug.Log("my age in months: " + myAgeInMonths);

        //this will pause the editor
        Debug.Break();
        //logs error message, will pause the inspector
        Debug.LogError("theres an error in the system :o");
        //logs error message, won't pause the inspector
        Debug.LogWarning("warning bish!!!");
    }

    // Update is called once per frame
    void Update()
    {
        //this is an example of how to checkvariables later on in coding
        myAgeInMonths = 23;
        Debug.Log("Age in months is now: " + myAgeInMonths);
        
    }
}
