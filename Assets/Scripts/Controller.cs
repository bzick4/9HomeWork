using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"+++");
        Debug.Log(collision.gameObject.name);
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log($"---");
    }
    
}
