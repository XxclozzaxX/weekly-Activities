using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFinder : MonoBehaviour
{
    public static ScriptFinder scriptFinderInstance;
    // an example of a static instance
    private ScriptToFind scriptToFind;
    // a referance to the script to find
    public Transform objectTransform;
    // a referance to the object transform that has our script to find

    public ScriptToFind scripttofind2; 

    private void Awake()
    {
        scriptFinderInstance = this;
        // this keyword refers to this instance of this script
        scripttofind2.setname("chloe");
        scripttofind2.myName = "chloe";
    }

    // Start is called before the first frame update
    void Start()
    {
        scriptToFind = GetComponent<ScriptToFind>();
        // this one will search the object for attached scripts
        scriptToFind = FindObjectOfType<ScriptToFind>();
        // this one will search the object transform referance for the
        // script that it is attached to
        scriptToFind = objectTransform.GetComponent<ScriptToFind>();
        // this one will find the first instance of the script
    }

}
