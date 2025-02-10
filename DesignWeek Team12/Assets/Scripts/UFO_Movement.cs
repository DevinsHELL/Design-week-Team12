using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class UFO_Movement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float alltitudeChange = 0.1f;

    float verticalMovement;
    float horizontalMovement;
    Vector3 moveDirection;

    Rigidbody rb;

    float beamlenth = 2.7f; // lenth of tyhe raycast
    [SerializeField] public LayerMask detect; // detect layer 

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // grabs the rigudbody
        rb.freezeRotation = true; // freezes rigidbody rotation

        
       
    }

    // Update is called once per frame
    void Update()
    {
       
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
        if (Input.GetKey(KeyCode.Q))
        {
            
            
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
            Debug.Log("Hit " + hit.collider.name);
            
            
        }
        Debug.DrawRay(beamOrigin, beamDirection * beamlenth, Color.red);
    }
}
