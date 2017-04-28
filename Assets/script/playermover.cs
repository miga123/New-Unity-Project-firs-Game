using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover : MonoBehaviour
{
    
    public Transform player;
    public Rigidbody playerBody;
    public float SpeedMultuplayer;

    Vector3 deltaPos;


    void Start ()
    {
        deltaPos = Vector3.zero;
	}
	
	
	void Update ()
    {
        //Debug.Log (Input.GetKey(KeyCode.DownArrow) );

        deltaPos.z = Input.GetAxis("Vertical");
        deltaPos.x = Input.GetAxis("Horizontal");

       


       // Input.GetAxis("Horizontal"));


        // player.position = player.position + deltaPos;
        //short form
       // transform.position += deltaPos;

    }

     void FixedUpdate()
    {
        playerBody.position = playerBody.position + deltaPos;
        playerBody.AddForce(deltaPos * SpeedMultuplayer);
    }

}
