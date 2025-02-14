using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamPull : MonoBehaviour
{
    private Cow_movement fat;
    private fireflys beam;

    public Vector3 targetPosition; // The position the object will be pulled towards
    public float speed = 2f; // Speed at which the object moves
    //float ground = -1.17f;
    public static int weightC = 0;
    
    // Update is called once per frame
    void Update()
    {
        // The object only moves when 'pull()' is triggered from CowT
       
    }
    private void Start()
    {
        if (beam == null) 
        {
            beam = FindObjectOfType<fireflys>();  // Finds the script
        }

        if (beam == null)
        {
            Debug.LogError("No fireflys script ");
        }
    }

    public void pull()
    {
        if (beam == null)
        {
            //Debug.LogError("Beam reference is missing");
            return;
        }
        if (Input.GetKey(KeyCode.F) && weightC == beam.beamStrenth || weightC < beam.beamStrenth) 
        {
           
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            // Moves the object towards the target position at a set speed
        }
        else
        {
          //transform.Translate(0,ground * Time.deltaTime * 5,0);
        }
    }
}
    


