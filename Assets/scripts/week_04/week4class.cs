using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class week4class : MonoBehaviour
{
    public int leapYear = 366;
    public int normalYear = 365;
    public int year;
    // Start is called before the first frame update
    void Start()
    {
        year = Random.Range(365, 367);
        if(year > 365)
        {
            Debug.Log("leap year");
        }
        else
        {
            Debug.Log("normal year");
        }

        FarIntoCel();
    }

    public void FarIntoCel()
    {
        int far = 68;
        int cel = 0;

        if(far == 68)
        {
            far -= 32;
            Debug.Log("I've got: " + far + " far");
            if(far == 36)
            {
                cel = (int)(36 * 0.555);
                Debug.Log("our cel is: " + cel + " cel");
            }
        }
    }
}
