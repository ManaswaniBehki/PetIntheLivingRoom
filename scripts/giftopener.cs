using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giftopener : MonoBehaviour
{
    public GameObject agiftbox;
    public Collider collision; // Reference to the door's collider component
    
    private bool isOpen = false;

    void Update()
    {
        if (isOpen)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                agiftbox.SetActive(false);
                isOpen = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            agiftbox.SetActive(false);
            isOpen = true;
            collision.enabled = false;
        }
    }
}
