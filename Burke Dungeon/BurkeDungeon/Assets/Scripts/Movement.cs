﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Animator animator;
    public float speed;
    Vector2 v2;

   

    // Update is called once per frame
    void Update()
    {
      

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        
        transform.position = transform.position + movement * speed * Time.deltaTime;



    }
}
