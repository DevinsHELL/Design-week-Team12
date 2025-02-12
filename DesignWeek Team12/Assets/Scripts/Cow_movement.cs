using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow_movement : MonoBehaviour
{
    //public float mass = 0.5f;
    public float moveSpeedR = 5;
    public int pickup; // for powerup weight

    private Rigidbody rb;
    private SpriteRenderer spriterenderer;
    private beamPull ItemCount;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //spriterenderer = rb.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerINP();
        // weight();
    }
    private void FixedUpdate()
    {
       // rb.velocity = new Vector2(Input.GetAxisRaw("horizontal"),0f);
       // spriterenderer.flipX = rb.velocity.x > 0;
    }
    void PlayerINP()
    {

        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.U)) moveDirection += Vector3.forward;
        if (Input.GetKey(KeyCode.J)) moveDirection += Vector3.back;
        if (Input.GetKey(KeyCode.H)) moveDirection += Vector3.left;
        
        if (Input.GetKey(KeyCode.K)) moveDirection += Vector3.right;

        rb.velocity = moveDirection * moveSpeedR;

    }
}
