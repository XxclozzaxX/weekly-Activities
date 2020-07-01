using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoRecap : MonoBehaviour
{
    public string myName = "chloe";
    public int myFaveInt = 17;
    public float myFaveFloat = 5.4f;
    public bool MyFaveBool = false;

    // Start is called before the first frame update
    void Start()
    {
        // example of random range and float
        myFaveInt = Random.Range(0, 11);
        myFaveFloat = Random.Range(0f, 10f);

        // temporary variables
        string lastName = "buckley";
        int myFirstCalc = 0;
        int mySecondCalc = myFirstCalc;

        // different examples of if statements
        if (MyFaveBool == false)
        {
            Debug.Log("this is true");
        }

        if (myName == "chloe")
        {
            Debug.Log("this is true");
        }

        if (myFaveInt > 0)
        {
            Debug.Log("this is true");
        }

        if (myFaveFloat <= 100)
        {
            Debug.Log("this is true");
        }

        if (myFaveFloat == 1)
        {
            Debug.Log("this is true");
        }

        if (lastName == "buckley")
        {
            Debug.Log("this is true");
        }
        else
        {
            Debug.Log("this is false");
        }

        if (myName == "chloe")
        {
            Debug.Log("this is true");
            if (lastName == "Buckley")
            {
                Debug.Log("your chloe");
            }
            else
            {
                Debug.Log("do something else");
            }
        }
        else if (lastName == "buckley")
        {
            Debug.Log("were in else if");
        }

        /// && if any statement is false
        /// this statement will not play out
        if (myName != "chloe" && lastName == "buckley" && myFaveInt == 17)
        {
            Debug.Log(myName = " " + lastName);
        }
        /// this will only not play out
        /// if both sides of the or are flase
        if (myName != "chloe" || lastName == "buckley" && myFaveInt == 17)
        {
            Debug.Log(myName = " " + lastName);
        }
        /// use the parentheses to define what your conditions are
        /// and also how many there are
        if ((myName != "chloe" || lastName == "buckley") && myFaveInt == 17)
        {
            Debug.Log(myName = " " + lastName);
        }
    }
}

