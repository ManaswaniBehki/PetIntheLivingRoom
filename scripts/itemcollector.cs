using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemcollector : MonoBehaviour
{
    int ducks = 0;
    [SerializeField] Text scoretextduck;

   
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("duckies"))
        {
            Destroy(other.gameObject);
            ducks++;
            scoretextduck.text = "Ducks:" + ducks + "/5";

        }
    }
   
}
