using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fireflys : MonoBehaviour
{
    private Rigidbody rb;
    public int beamStrenth = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fireF"))
        {
            beamStrenth++;
            Debug.Log("Picked up "+ beamStrenth);
            Destroy(other.gameObject); // Destroy the power-up object after collision

        }
    }
}
