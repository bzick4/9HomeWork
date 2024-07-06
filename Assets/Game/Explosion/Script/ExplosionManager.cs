    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

public class ExplosionManager : MonoBehaviour
{
    public bool isExplosion { get; private set; }
    [SerializeField] private float radius, force, _upWards;
    private float timeToExplosion;

    private void Update()
    {
        timeToExplosion -= Time.deltaTime;
        if (timeToExplosion <= 0 && isExplosion)
        {
            Explode();
        }
    }
    public void StartExplosion()
    {
        isExplosion = true;
    }
    public void StopExplosion()
    {
        isExplosion = false;
    }
    public void Explode()
    {
        Rigidbody[] block = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody B in block)
        {
            float dist = Vector3.Distance(transform.position, B.transform.position);
            if (dist < radius)
            {
                Vector3 direction = B.transform.position - transform.position;
                B.AddForce(direction.normalized * force*(radius-dist), ForceMode.Impulse);
            }
        }

        timeToExplosion = 3;
    }
}
