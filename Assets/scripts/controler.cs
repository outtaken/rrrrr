﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour {
    public float speed= 10.0f;
	public float jumpheight =3.0f;
    public float gravity = -9.8f;
	public static bool Key=false;
	public static bool Key1=false;
	public static bool Key2=false;
	public static int health=100;
	public static bool door=false;
	public static bool door1=false;
	public static bool door2=false;
        private CharacterController _charCont;


	// Use this for initialization
	void Start () {
        _charCont = GetComponent<CharacterController>();


		
	}
     void FixedUpdate() 
    {
      
        
		

    }

    // Update is called once per frame
	void Update ()
{
    float deltaX = Input.GetAxis("Horizontal") * speed;
    float deltaZ = Input.GetAxis("Vertical") * speed;
    Vector3 movement = new Vector3(deltaX, 0, deltaZ);
    movement = Vector3.ClampMagnitude(movement, speed);
    movement.y = gravity;
    movement *= Time.deltaTime;
    movement = transform.TransformDirection(movement);
    _charCont.Move(movement);
    if (Input.GetKeyDown(KeyCode.Space))
    {
        Vector3 jump = new Vector3(0, jumpheight, 0);
        jump = Vector3.ClampMagnitude(jump, jumpheight);
        _charCont.Move(jump);
    }
}
}