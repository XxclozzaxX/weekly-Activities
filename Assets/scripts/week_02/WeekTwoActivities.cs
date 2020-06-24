using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoActivities : MonoBehaviour
{
    public string myFaveGame = "child of light";
    public int hoursPlayed = 100;
    public float costOfGame = 20.00f;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("my faveirote game is " + myFaveGame);
        Debug.Log("i have played it for " + hoursPlayed + " hours");
        Debug.Log("it cost me " + costOfGame);
        Debug.Log("my cost per hour is: " + costOfGame / hoursPlayed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
