using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRoad : MonoBehaviour
{
    private float _speed = 5;
    
    private void Update()
    {
        DestroyRoad();
    }
    
    private void DestroyRoad()
    {
        if (transform.position.z < -50f)
        {
            Destroy(gameObject);
        }
    }
}
