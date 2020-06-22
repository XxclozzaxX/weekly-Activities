using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperandsTutorial : MonoBehaviour
{
    public string myName = "chloe"; // stores users name
    public int myAgeInYears = 19; //stors users age in years
    public int myAgeInMonths = 2; //stors user age in months
    public int myAgeInWeeks = 0; // stors user age in weeks
    public int myAgeInDays = 0; // stors user age in days
    public int myBirthdayDay = 2; // stors users bitrh day
    public int myBirthdayMonth = 5; // stores users birth month
    public int myBirthdayYear = 2001; // stores users birth year

    // Start is called before the first frame update
    void Start()
    {
        // tempoary string message to hold debug message
        string myDebugMessage = "my name is: " + myName;
        string myDegugMessage = "my birthday is: " + myBirthdayDay + "/" + myBirthdayMonth + "/" + myBirthdayYear;
        myDebugMessage = myDebugMessage + " my age in years is: " + myAgeInYears;

        // an example of the multiplacation operand
        // can also use plus, minus, multiplacation or divide
        myAgeInYears = myAgeInMonths * 12;
        //debug out progress to check its working
        Debug.Log("my age in months is: " + myAgeInMonths);
        myAgeInWeeks = myAgeInMonths * 4;
        myAgeInDays = myAgeInWeeks * 7;

        //this is a shortcut 
        myDebugMessage += " my age in months: " + myAgeInMonths;
        myDebugMessage += " my age in weeks is: " + myAgeInWeeks;
        myDebugMessage += " my age in days: " + myAgeInDays;

        Debug.Log(myDebugMessage);

        //this is an example of mudulos, it divides the left by the right and returnes that ramainds, useful for even division
        Debug.Log("this is an example of modulous, it devides the number evenly and returned the reminder " + myAgeInDays % 5);
    }
}
