using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createdemstats : MonoBehaviour
{

    public int strength;
    public int agility;
    public int intellegance;
    public int statPool = 20;
    

    // Start is called before the first frame update
    void Start()
    {
        int currentStatPointsAssigned = Random.Range(0, statPool);

        agility = currentStatPointsAssigned;
        statPool = statPool - currentStatPointsAssigned;

        currentStatPointsAssigned = Random.Range(0, statPool);

        strength = currentStatPointsAssigned;
        statPool = statPool - currentStatPointsAssigned;

        intellegance = statPool;
        statPool = 0;
    }
}
