using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool isMovement { get; private set; }
    private bool isSlideLeft,isSlideRight;
    [SerializeField]private float _forceAmount, _slideAmount;
    
    private Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        MoveHero();
        Slide();
    }
    private void FixedUpdate()
    {
        if (isMovement)
        {
            rb.velocity = Vector3.forward*_forceAmount;
        }
        if (isSlideLeft)
        {
            rb.velocity=Vector3.left*_slideAmount;
        }
        if (isSlideRight)
        {
            rb.velocity = Vector3.right*_slideAmount;
        }
    }
    
    public void StartMovement()
    {
        isMovement = true;
    }
    public void StopMovement()
    {
        isMovement = false;
        isSlideRight = false;
        isSlideLeft = false;
    }
    private void MoveHero()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            isMovement = true;
            isSlideLeft = false;
            isSlideRight = false;
        }
    }
    private void Slide()
{
    if (Input.GetKeyDown(KeyCode.A)) // Move left
    {
        isMovement = true;
        isSlideLeft = true;
        isSlideRight = false;
    }
    else if (Input.GetKeyDown(KeyCode.D)) // Move right
    {
        isSlideRight = true;
        isMovement = true;
        isSlideLeft = false;
    } 
}
}
