using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowT : MonoBehaviour
{
    private beamPull closestCow; // Store the closest object

    // Update is called once per frame
    void Update()
    {
        FindClosestCow(); // Continuously find the closest object

        if (closestCow != null && Input.GetKey(KeyCode.F)) // If an object is found and F is pressed
        {
            closestCow.targetPosition = transform.position; // Set pull target to this object's position
            closestCow.pull(); // Call the pull function on the object
        }
    }

    void FindClosestCow()
    {
        float distanceToCow = Mathf.Infinity;  // Sets search distance to infinity
        beamPull[] allCows = GameObject.FindObjectsOfType<beamPull>(); // Creates an array of all objects with the beamPull script

        foreach (beamPull currentCow in allCows) // Loop through all objects found
        {
            float currentDistance = (currentCow.transform.position - transform.position).sqrMagnitude; // Calculate distance from this object

            if (currentDistance < distanceToCow)
            {
                distanceToCow = currentDistance;  // Update the closest distance
                closestCow = currentCow;  // Assign the closest object
            }
        }

        if (closestCow != null)
        {
            Debug.DrawLine(transform.position, closestCow.transform.position, Color.red); 
            //Debug.Log("Drawing line to " + closestCow.name);
        }
        else
        {
           // Debug.Log("None found"); 
        }
    }
}
