using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationball : MonoBehaviour
{
    public GameObject water;
    public GameObject water2;
    
    public Collider collision; // Reference to the door's collider component
    private MeshRenderer water2Renderer; // Reference to the MeshRenderer component on water2

    private void Start()
    {
        // Get the MeshRenderer component from the water2 GameObject
        water2Renderer = water2.GetComponent<MeshRenderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Player has entered the collider, so enable water2 and its Mesh Renderer
            water.SetActive(false);
            water2.SetActive(true);
            water2Renderer.enabled = true; // Enable the MeshRenderer
            collision.enabled = false;
        }
    }

    // You may also want to add an OnTriggerExit method to handle when the player exits the collider
    // This depends on your specific requirements.
}
