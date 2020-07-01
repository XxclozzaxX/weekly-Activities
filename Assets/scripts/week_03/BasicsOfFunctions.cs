using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicsOfFunctions : MonoBehaviour
{
    public string myFirstName = "chloe";
    public string myLastName = "buckley";
    public int myAgeInY = 19;
    public int myAgeInM = 2;
    public int myAgeInW = 0;

    // this is a function called before start
    public void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        // an example of how to call a function
        PrintFullName();
    }

    // Update is called once per frame
    void Update()
    {
        PrintMyClassTime();
    }
    // assess type || return type || function name
    public void PrintFullName()
    {
        Debug.Log(myFirstName + " " + myLastName);
        // a function can be called inside of another function
        PrintMyAge();
    }

    // the anatomy of a function follows
    // the access type: public / private
    // the return type: void - return nothing, just do instructions
    // the function name, all caps for words
    // finally the parentheses and curly braces

    public void PrintMyAge()
    {
        Debug.Log("call print my name");
        // tempoary variables
        int monthsInAY = 12;
        int weeksInAM = 4;
        int daysInAW = 7;
        int myAgeInD = 0;

        // calculates the users age in months, weeks and days
        myAgeInM = myAgeInY * monthsInAY;
        myAgeInW = myAgeInM * weeksInAM;
        myAgeInD = myAgeInW * daysInAW;
        // and example of how debug.log effectivly in a function
        Debug.Log("my age in days is: " + myAgeInD);
        // prints out the users age in months, weeks and days
        Debug.Log("my age is " + myAgeInY + " years old, which is " + myAgeInM + " in months," +
            " which is " + myAgeInW + " in weeks, which is " + myAgeInD);
    }
    public void PrintMyClassTime()
    {
        Debug.Log("My class is wednesday at 15:00");
    }

}
