using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weektwoifstatements : MonoBehaviour
{

    public float myFloat;

    // Start is called before the first frame update
    void Start()
    {
        myFloat = Random.Range(0f, 10f);

        if(myFloat == 1)
        {
            Debug.Log("the number was 1");
        }

        if (myFloat > 3)
        {
            Debug.Log("the nuber was greater than 3");
        }

        if (myFloat < 5)
        {
            Debug.Log("the number was less than 5");
        }

        if (myFloat > 3 || myFloat < 5)
        {
            Debug.Log("The number was less than 3 " +
                "or the number was greater than 5");
        }
        else
        {
            Debug.Log("the number was exactly 4");
        }

        if (myFloat > 1 && myFloat < 5 || myFloat > 7)
        {
            Debug.Log("the number was greater than 1 and " +
                "less than 5 or the number was greater " +
                "than 7");
        }
    }
}
