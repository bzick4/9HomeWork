using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWhiteBall : MonoBehaviour
{
    [SerializeField] private float _ballForce;
    public bool isMovementWhiteBall { get; private set; }
    private Rigidbody rbBall;

    private void Start()
    {
        rbBall = GetComponent<Rigidbody>();
    }
    public void StartMovement()
    {
        isMovementWhiteBall = true;
    }
    public void StopMovement()
    {
        isMovementWhiteBall = false;
    }
    private void FixedUpdate()
    {
        if (isMovementWhiteBall)
        {
            rbBall.AddForce(Vector3.forward * _ballForce, ForceMode.Impulse);
            StopMovement();
            //velocity = Vector3.forward * _ballForce;
        }
    }
}
