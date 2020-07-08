using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingcube : MonoBehaviour
{
    private MeshRenderer m_MyMeshRenderer; // stores the mesh render
    public Color startingColour; // stores the starting colour
    private Vector3 m_startingPoint; // stores the starting position
    public Vector3 endPoint;// stores the position we are moving to
    private Vector3 m_currentMovePosition; // stores the current position were coving to 

    // Start is called before the first frame update
    void Start()
    {
        // checks to see if the object the script is attached to has a mesh renderer 
        if(GetComponent<MeshRenderer>() == true)
        {
            m_MyMeshRenderer = GetComponent<MeshRenderer>();
        }
        else
        {
            Debug.LogError("no meshie boi");
        }

        // accessing the material of the object and changing the start colour
        m_MyMeshRenderer.material.color = startingColour;
        // we are storing our starting position when we start the game
        m_startingPoint = transform.position;

        endPoint = GetNewEndPoint(); 
    }
    private void Update()
    {
        
    }

    // returns a new end point based on the starting point and a random vector
    private Vector3 GetNewEndPoint()
    {
        // here we are creating a random end point
        return m_startingPoint + new Vector3(Random.Range(-5, 5),
            Random.Range(-5, 5), Random.Range(-5, 5));
    }
}
