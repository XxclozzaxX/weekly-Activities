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

    private string fullName;
    // pravate and cant be seen in another class

    // sets the instance enemy class with some default values
    public void SetUpEnemy()
    {
        myFirstName = "chloe";
        myLastName = "buckley";
        health = 100;
        mana = 100;
    }
}
