using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class week3recap : MonoBehaviour
{
    public string fullName = string.Empty;

    // Start is called before the first frame update
    void Start()
    {
        ASimpleVoidFunction();
        ASimpleVoidFunctionWithParamaters(5, true);
        ASimpleVoidFunctionWithParamaters(5);
        Debug.Log(ReturnFullName("chloe", "Buckley"));
        fullName = ReturnFullName("chloe", "buckley");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ASimpleVoidFunction()
    {
        // int myTempInt = 0;
        //if(true)
        //{

        //}
    }

    public void ASimpleVoidFunctionWithParamaters(int MyAwesomeInt, bool IsDone = false)
    {
        Debug.Log("my int was: " + MyAwesomeInt);
        if(IsDone)
        {
            Debug.Log("IsDone");
        }
    }

    public string ReturnFullName(string FirstName, string LastName)
    {
        return FirstName + " " + LastName;
    }
}
