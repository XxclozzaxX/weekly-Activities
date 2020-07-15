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
    public float movespeed = 5; // amount of force applied to the cube

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
        // here we create a random point
        endPoint = GetNewEndPoint();
        m_currentMovePosition = endPoint;
    }

    void Update()
    {
        MovePlatform(); 
    }

    // updates the current position
    private void MovePlatform()
    {
        transform.position = Vector3.Lerp(transform.position,
            m_currentMovePosition, movespeed * Time.deltaTime);

        // if we are close to the end we get the start position and move towards that
        if (Vector3.Distance(transform.position, endPoint) <= 0.1f)
        {
            m_currentMovePosition = m_startingPoint;
            // accessing the mesh renderer and changing the colour to a random colour
            m_MyMeshRenderer.material.color = RetuenRandomColour();
        }
        else if (Vector3.Distance(transform.position, endPoint) <= 0.1f)
        {
            endPoint = GetNewEndPoint();
            m_currentMovePosition = endPoint;
            // accessing the mesh renderer and changing the colour to a random colour
            m_MyMeshRenderer.material.color = RetuenRandomColour();
        }
    }

    // changing the colour of the cube to a random colour
    private Color RetuenRandomColour()
    {
        return new Color(Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    // returns a new end point based on the starting point and a random vector
    private Vector3 GetNewEndPoint()
    {
        // here we are creating a random end point
        return m_startingPoint + new Vector3(Random.Range(-5, 5),
            Random.Range(-5, 5), Random.Range(-5, 5));
    }
}
