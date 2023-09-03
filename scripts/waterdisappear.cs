using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterdisappear : MonoBehaviour
{
    public GameObject water;
    
    
    public Collider collision; // Reference to the door's collider component

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
             water.SetActive(true);
            collision.enabled = false; 
            
        }
        water.SetActive(false);
    }
}
