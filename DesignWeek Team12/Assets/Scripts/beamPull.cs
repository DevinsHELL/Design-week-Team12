using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamPull : MonoBehaviour
{
    private CowT moveP;
    public Vector3 targetPosition; // pull pos
    float speed = 2f; // pull speed
    //public int onoff = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (onoff == 1)
       // {
            pull();
        //}
    }
    void pull()
    {
        if (Input.GetKey(KeyCode.F))
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime); // moves attached objects towrads a point that is specified
        }
    }
}
