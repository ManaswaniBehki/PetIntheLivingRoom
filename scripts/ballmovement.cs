using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    public Rigidbody water2Rigidbody; // Reference to the Rigidbody component on water2
    public float forceMagnitude = 10f; // Adjust this value to control the force applied
    public Vector3 forceDirection = Vector3.up; // Adjust this direction as needed

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Player has entered the trigger collider, so apply a force to the Rigidbody
            water2Rigidbody.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
        }
    }

    // You may also want to add an OnTriggerExit method to handle when the player exits the trigger collider
    // This depends on your specific requirements.
}
