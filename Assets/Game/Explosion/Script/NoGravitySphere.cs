using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoGravitySphere : MonoBehaviour
{
    [SerializeField] private Transform center;
    [SerializeField] private float _radiusSphere, _speedSphere;
    private float posX, posY, posZ, angle;
    private bool _isRotate;

    public void StartRotate()
    {
        _isRotate = true;
    }

    public void StopRotate()
    {
        _isRotate = false;
    }
    private void Update()
    {
        Rotation();
    }
    public void Rotation()
    {
        if (_isRotate)
        {
            posX = center.position.x + MathF.Cos(angle) * _radiusSphere;
            posZ = center.position.z + MathF.Sin(angle) * _radiusSphere;
            posY = center.position.y + MathF.Tan(angle) * _radiusSphere;
            transform.position = new Vector3(posX, 3.5f, posZ);
            angle = angle + Time.deltaTime * _speedSphere;
            if (angle > 360f)
            {
                angle = 0f;
            }
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("ObjectForExplosion"))
        {
            other.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("ObjectForExplosion"))
        {
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
    
    
}
