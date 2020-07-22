using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptToFind : MonoBehaviour
{
    public string myName;
    public ScriptFinder scriptfinder;

    // Start is called before the first frame update
    void Start()
    {
        scriptfinder = FindObjectOfType<ScriptFinder>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setname(string name)
    {
        myName = name;
    }
}
