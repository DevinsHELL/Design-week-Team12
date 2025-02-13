using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamPull : MonoBehaviour
{
    private Cow_movement fat;

    public Vector3 targetPosition; // The position the object will be pulled towards
    public float speed = 2f; // Speed at which the object moves
    float ground = -1.17f;
    public static int weightC = 0;
    // Update is called once per frame
    void Update()
    {
        // The object only moves when 'pull()' is triggered from CowT
       // weight();
    }

    public void pull()
    {
        if (Input.GetKey(KeyCode.F) && weightC < 3) 
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            // Moves the object towards the target position at a set speed
        }
        else
        {
          //transform.Translate(0,ground * Time.deltaTime * 5,0);
        }
    }
    public void weight()
    {
        if (fat.pickup <= 1)
        {
            speed = 2f;
        }
        if (fat.pickup > 1)
        {
            speed = 2f;
            while (fat.pickup < 4)
            {
                speed = 2;
                if (fat.pickup >= 4)
                {
                    speed = 1;
                    if (fat.pickup > 6)
                    {
                        speed = 0.5f;
                    }
                }
            }
        }
    }
}
    


