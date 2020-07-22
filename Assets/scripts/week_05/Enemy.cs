using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Level01;

public class Enemy : MonoBehaviour
{
    public string myFirstName; // enemy first name
    public string myLastName; // enemy last name
    public int health; // enemy health
    public int mana; // enemy mana
    private string FullName; // private variable
    // an example of a get and a set
    // access type, data type and name || like a return function
    public int Health
    {
        get
        {
            // i might want to debug or do something here
            return health;
        }
        set
        {
            // what this value is set, change ui
            // increse or decrese the death effect
            health = value;
        }
    }

    public string fullName
    {
        get
        {
            Debug.Log("my namo is " + FullName);
            return FullName;
        }
        set
        {
            Debug.Log(value);
            FullName = value;
        }
    }

    // pravate and cant be seen in another class

    // sets the instance enemy class with some default values
    public void SetUpEnemy()
    {
        myFirstName = "chloe";
        myLastName = "buckley";
        health = 100;
        mana = 100;
        Health = 100;
        // this is an example of using set 
        fullName = "chloe";
        // this is an example of get
        Debug.Log("testing get " + fullName);
    }
}
