using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow_movement : MonoBehaviour
{
    //public float mass = 0.5f;
    public float moveSpeedR = 5;
    public float boostedSpeed = 10;
    public float boostDuration = 5f; // Duration of the speed boost
    public int pickup; // for powerup weight

    private Rigidbody rb;
    private SpriteRenderer spriterenderer;
    private beamPull ItemCount;
    private float originalSpeed; // Store the original speed
    private bool isBoosted = false; // Flag to track if the cow is boosted
    private float boostTimer = 0f; // Timer to track the duration of the boost

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalSpeed = moveSpeedR;
        spriterenderer = rb.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerINP();
        // weight();

        // Check if the cow is boosted and update the timer
        if (isBoosted)
        {
            boostTimer -= Time.deltaTime;
            if (boostTimer <= 0)
            {
                moveSpeedR = originalSpeed;
                isBoosted = false;
            }
        }
    }

    private void FixedUpdate()
    {
         //rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal2"),0f);
         //spriterenderer.flipX = rb.velocity.x > 0;
    }

    void PlayerINP()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.U)) moveDirection += Vector3.forward;
        if (Input.GetKey(KeyCode.J)) moveDirection += Vector3.back;
        if (Input.GetKey(KeyCode.H)) moveDirection += Vector3.left;
        if (Input.GetKey(KeyCode.K)) moveDirection += Vector3.right;

        rb.velocity = moveDirection * moveSpeedR;

        // flip the sprite for the cow
        if (Input.GetKey(KeyCode.K))
            spriterenderer.flipX = true; // Face left
        if (Input.GetKey(KeyCode.H))
            spriterenderer.flipX = false; // Face right
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            ActivateSpeedBoost();
            cowWeight();
            Destroy(other.gameObject); // Destroy the power-up object after collision
            
        }
    }

    void ActivateSpeedBoost()
    {
        moveSpeedR = boostedSpeed;
        isBoosted = true;
        boostTimer = boostDuration;
    }
    void cowWeight()
    {
        beamPull.weightC++;
        Debug.Log("Weight " + beamPull.weightC);
    }
}
