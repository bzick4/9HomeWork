using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering.Universal;
public class Game : MonoBehaviour
{
    [SerializeField] private float impactForce;
    //public static event Action ballInHole;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Balls"))
        {
            Rigidbody ballsRigidbody = other.GetComponent<Rigidbody>();
            if(ballsRigidbody != null)
            {
                Vector3 direction = (other.transform.position - transform.position).normalized; // Вычисляем направление отталкивания
                ballsRigidbody.AddForce(direction); // Применяем силу для отталкивания
            }
        }
    }
}
