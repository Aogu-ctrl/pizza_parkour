﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Capsulcontroller : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
   

    void Update()
    {


        CharacterController controller = GetComponent<CharacterController>();

        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        // Move forward / backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * 1.0f;
        controller.SimpleMove(forward * curSpeed);

        Physics.gravity = new Vector3(0, -30.0F, 0);

       

    }
    
}
