using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering.Universal;
public class PoolGame : MonoBehaviour
{
    public static event Action BallDown;

    private void BallInHole()
    {
        BallDown?.Invoke();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Hole"))
        { 
            BallInHole();
        }
    }
}
