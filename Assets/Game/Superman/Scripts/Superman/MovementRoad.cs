using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRoad : MonoBehaviour
{
    private float _speed = 5;
    public bool isMovement { get; private set; }

    public void StartMovement()
    {
        isMovement = true;
    }

    public void StopMovement()
    {
        isMovement = false;
    }
    
    private void Update()
    {
        DestroyRoad();
    }
    private void FixedUpdate()
    {
        Movement();
    }

    public void Movement()
    {
        if (isMovement == true)
        {
            transform.Translate(-transform.forward * _speed * Time.fixedDeltaTime);
        } 
    }
    
    private void DestroyRoad()
    {
        if (transform.position.z < -50f)
        {
            Destroy(gameObject);
        }
    }
}
