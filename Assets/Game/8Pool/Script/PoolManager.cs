using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(0,0,5, ForceMode.Force);
    }
}
