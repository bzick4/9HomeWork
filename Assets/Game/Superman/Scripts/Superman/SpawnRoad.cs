using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoad : MonoBehaviour
{
    [SerializeField] private GenerationRoad _generationRoad;
    private void OnTriggerEnter(Collider other)
    {
        _generationRoad.Spawn();
    }
}
