using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class UFO_Movement : MonoBehaviour
{
    private UFO_Beam ufoBeam; //references the UFO_beam script

    public float moveSpeed = 3.5f;
    public float alltitudeChange = 0.1f;

    float verticalMovement;
    float horizontalMovement;
    Vector3 moveDirection;

    public Rigidbody rb;

    public float beamlenth = 1f; // lenth of tyhe raycast
    [SerializeField] public LayerMask detect; // detect layer 


    public bool rayCasttoggle = false;

    public float amp; 
    public float freq;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // grabs the rigudbody
        rb.freezeRotation = true; // freezes rigidbody rotation 
       
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0, Mathf.Sin(Time.time* freq) * amp,0); // uses the sign wave to create a smooth bobbing movement that updates as time passes
        //note add it so it allows movement
        tractorBeam();
    }
    private void FixedUpdate()
    {
        UserControls();
        movePlayer();
    }
    public void UserControls()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal"); //returns a value a 1 if the player is holding the D key
        verticalMovement = Input.GetAxisRaw("Vertical"); // returns -1 if the player is holding the A key;

        moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement; // move the player based on the direction that it is currently facing

        
    }
    void movePlayer()
    {
        rb.AddForce(moveDirection.normalized * moveSpeed, ForceMode.Acceleration);

        //for vertical movement if needed
        if (Input.GetKey(KeyCode.Q))
        {
           // transform.position = Vector3.down * alltitudeChange;
            
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            
        }
        else
        {

        }
    }
    void tractorBeam()
    {
        RaycastHit hit;
        Vector3 beamOrigin = transform.position;
        Vector3 beamDirection = -transform.up;

        if (Physics.Raycast(beamOrigin, beamDirection, out hit, beamlenth, detect))
        {
            //Debug.Log("Hit " + hit.collider.name);
            
            Destroy(hit.transform.gameObject); // destroys the hit object for testing purposes
            
            rayCasttoggle = true;
            //Debug.Log("" + rayCasttoggle);
        }
        else
        {
            rayCasttoggle = false;
           // Debug.Log("" + rayCasttoggle);
        }
        Debug.DrawRay(beamOrigin, beamDirection * beamlenth, Color.red);
    }
    
}
