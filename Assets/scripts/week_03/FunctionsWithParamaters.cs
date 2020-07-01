using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParamaters : MonoBehaviour
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
        // an example of how to call a function with paramaters
        PrintFullName(myFirstName, myLastName, myAgeInY);
        // an example of using an optional paramater
        PrintFullName("louise", "louisa");
    }

    // Update is called once per frame
    void Update()
    {
        PrintMyClassTime();
    }
    // assess type || return type || function name

    // the anatomy of a function follows
    // the access type: public / private
    // the return type: void - return nothing, just do instructions
    // the function name, all caps for words
    // finally the parentheses and curly braces

    // inside of our parentheses i can declare rempoary variables which can store data
    // from when the function is called
    // this allowes me to reuse this fucntion more effectivly
    // when we use the = sign here we can set default values for our paramaters
    // just make sure that they are at the end of that paramater list
    public void PrintFullName(string FirstName, string LastName, int MyAge = -1)
    {
        Debug.Log(FirstName + " " + LastName);
        if(MyAge > 0)
        {
            PrintMyAge(MyAge);

            PrintMyAge(MyAge - 10);
        }
        // a function can be called inside of another function
    }

    public void PrintMyAge(int MyAgeInYears)
    {
        Debug.Log("call print my name");
        // tempoary variables
        int monthsInAY = 12;
        int weeksInAM = 4;
        int daysInAW = 7;
        int myAgeInD = 0;

        // calculates the users age in months, weeks and days
        // here we notice i am using my paramater instead of my variable
        // this allowes me to use whatever value i store in my paramater
        // making my code more reuseable
        myAgeInM = MyAgeInYears * monthsInAY;
        myAgeInW = myAgeInM * weeksInAM;
        myAgeInD = myAgeInW * daysInAW;
        // and example of how debug.log effectivly in a function
        Debug.Log("my age in days is: " + myAgeInD);
        // prints out the users age in months, weeks and days
        Debug.Log("my age is " + MyAgeInYears + " years old, which is " + myAgeInM + " in months," +
            " which is " + myAgeInW + " in weeks, which is " + myAgeInD);
        Debug.Log("print my age complete");
    }
    public void PrintMyClassTime()
    {
        Debug.Log("My class is wednesday at 15:00");
    }
}
