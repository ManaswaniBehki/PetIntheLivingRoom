using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opentv : MonoBehaviour
{
    public GameObject cubee;
    
    
    public Collider collision; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            cubee.SetActive(true);
            collision.enabled = false; 
            
        }
        cubee.SetActive(false);
    }
}
