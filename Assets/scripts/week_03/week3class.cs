using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class week3class : MonoBehaviour
{
    public string firstName = "chloe";
    public string lastName = "buckley";
    public int myAgeInY = 19;
    public int myAgeInM = 0;
    public int myAgeInW = 0;
    public int myAgeInD = 0;
    public int strength = 0;
    public int agility = 0;
    public int intellegance = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("my name is: " + firstName + " my last name is: " + lastName);

        int monthsInYear = 12;
        int weeksInAMonth = 4;
        int daysInAWeek = 7;

        myAgeInY = myAgeInY * monthsInYear;
        myAgeInM = myAgeInY * monthsInYear;
        myAgeInW = myAgeInM * weeksInAMonth;
        myAgeInD = myAgeInW * daysInAWeek;

        Debug.Log("my age is in different forms " + myAgeInY + " months " + myAgeInM + " weeks "
            + myAgeInW + " days " + myAgeInD + " this is a lot");

        PrintPowerLevel(strength, agility, intellegance);
    }

    // Update is called once per frame
    public void PrintPowerLevel(int strength, int agility, int intellegance)
    {
        // small / big * 100
        // return (int) 0;

        strength = Random.Range(0, 20);
        agility = Random.Range(0, 20);
        intellegance = Random.Range(0, 20);

        Debug.Log("my strength " + strength * 2);
        Debug.Log("my agility " + agility * 1.5);
        Debug.Log("my intellegance " + intellegance);
    }
}
