using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowT : MonoBehaviour
{
    
    private beamPull closestCow; // Store the closest object
    private bool inCollider = false; // Flag to check if an object is in the collider

    // Update is called once per frame
    private void Start()
    {
        
    }
    void Update()
    {
        
        
            if (inCollider && closestCow != null && Input.GetKey(KeyCode.F)) // If an object is in the collider and F is pressed
            {
                closestCow.targetPosition = transform.position; // Set pull target to this object's position
                closestCow.pull(); // Call the pull function on the object
            }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<beamPull>() != null) // Check if the object has the beamPull script
        {
            inCollider = true;
            closestCow = other.GetComponent<beamPull>(); // Assign the closest object
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<beamPull>() != null) // Check if the object has the beamPull script
        {
            inCollider = false;
            closestCow = null; // Reset the closest object
        }
    }
}

