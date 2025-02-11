using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowT : MonoBehaviour
{
    private beamPull puller;

    // Update is called once per frame
    void Update()
    {
        closestCowPosition();
    }
    void closestCowPosition()
    {
        float distanceToCow = Mathf.Infinity;  // Sets search distance to infinity
        beamPull closestCow = null;  // Stores the closest cow object

        beamPull[] allCows = GameObject.FindObjectsOfType<beamPull>(); // Creates an array of all cows

        foreach (beamPull currentCow in allCows)
        {
            float currentDistance = (currentCow.transform.position - this.transform.position).sqrMagnitude;

            if (currentDistance < distanceToCow) 
            {
                distanceToCow = currentDistance;  // Update the closest distance
                closestCow = currentCow;  // Assign the closest cow object
            }
        }
        if (closestCow != null)
        {
            Debug.DrawLine(this.transform.position, closestCow.transform.position, Color.red);
            Debug.Log("drawing line " + closestCow.name);
            
        }
        else
        {
            Debug.Log("none found");
        }
    }
}
