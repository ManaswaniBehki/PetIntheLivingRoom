using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autodoor : MonoBehaviour
{
    public GameObject scare;
    public GameObject door2;
    
    public Collider collision; // Reference to the door's collider component

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
             scare.SetActive(true);
            collision.enabled = false; 
            door2.SetActive(false);// Disable the collider when the door opens
        }
        scare.SetActive(true);
    }
}
