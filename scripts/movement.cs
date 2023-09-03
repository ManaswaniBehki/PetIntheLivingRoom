using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rigid;
    [SerializeField] float movementspeed = 50f;
    [SerializeField] float jumpforce = 30f;
    

    void Start()
    {
        Debug.Log("HELLO OUTPUT");
        rigid = GetComponent<Rigidbody>();
          Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rigid.velocity = new Vector3(rigid.velocity.x,jumpforce,rigid.velocity.z);
        }
        float a=Input.GetAxis("Horizontal");
        float b=Input.GetAxis("Vertical");

        rigid.velocity = new Vector3(movementspeed*a,rigid.velocity.y,movementspeed*b);

         

        
        // bool isgrounded()
        // {
        //     return Physics.CheckSphere(groundCheck.position, .1f, ground);
        // }

        // if(Input.GetKey("up"))
        // {
        //     rigid.velocity = new Vector3(x,y,5);
        // }
        // if(Input.GetKey("down"))
        // {
        //     rigid.velocity = new Vector3(rigid.Velocity.x,rigid.Velocity.y,-5);
        // }
        // if(Input.GetKey("left"))
        // {
        //     rigid.velocity = new Vector3(-5,rigid.Velocity.y,Velocity.z);
        // }
        // if(Input.GetKey("right"))
        // {
        //     rigid.velocity = new Vector3(5,rigid.Velocity.y,Velocity.z);
        // }

    }
}