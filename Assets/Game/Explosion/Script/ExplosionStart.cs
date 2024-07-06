using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionStart : MonoBehaviour
{
    [SerializeField] private ExplosionManager _explosion;
    [SerializeField] private NoGravitySphere _sphere;

    private void Start()
    {
        _explosion.StopExplosion();
        _sphere.StopRotate();
    }
    public void ButtonStart()
    {
        _explosion.StartExplosion();
        _sphere.StartRotate();
        
    } 
}
