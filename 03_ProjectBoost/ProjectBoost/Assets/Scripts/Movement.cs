using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust() {
        if (Input.GetKey(KeyCode.Space)) {
            // Vector3.up = (0, 1, 0)
            rb.AddRelativeForce(Vector3.up);
        }
        
    }
    void ProcessRotation() {
        if (Input.GetKey(KeyCode.A)) {
            Debug.Log("Rotating Left");
        }
        else if (Input.GetKey(KeyCode.D)) {
            Debug.Log("Rotating Right");
        }
    }
}
