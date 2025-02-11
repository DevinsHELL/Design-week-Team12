using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_Beam : MonoBehaviour
{
    //beam light 
    [SerializeField] GameObject TBEAM; // creates a gameobject for the spotlight
    public bool Active = false; // will turn it on and off


    // Start is called before the first frame update
    void Start()
    {
        // beam starts off
        TBEAM.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (Active == false)

            {
                TBEAM.gameObject.SetActive(true);
                Active = true;
            }
            else
            {
                TBEAM.gameObject.SetActive(false);
                Active = false;
            }
        }
    }
}
