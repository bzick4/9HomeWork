using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;


public class GenerationRoad : MonoBehaviour
{
   [SerializeField] private List<GameObject> _roads;
   private GameObject _road;
   [SerializeField] private float _roadLenth;

   private void Start()
   {
      _road = Instantiate(_roads[Random.Range(0, _roads.Count - 1)], transform.position, Quaternion.identity);
   }
   
   public void Spawn()
   {
      Vector3 position = new Vector3(0, 0, _road.transform.position.z + _roadLenth);
         _road = Instantiate(_roads[Random.Range(0, _roads.Count - 1)],position, Quaternion.identity);
   }
}
