using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using Random = System.Random;


public class GenerationRoad : MonoBehaviour
{
   Random rnd = new Random();
   [SerializeField] private List<GameObject> _roads;
   [SerializeField] private GameObject _road;
   [SerializeField] private float _speed, _roadLenght;
   [SerializeField] private int _maxCount;
   [SerializeField] private List<Tile> _tiles = new List<Tile>();

   private void Start()
   {
         GenerateTile();
   }
   private void Update()
   {
   }

   private void GenerateTile()
   {
      _road = Instantiate(_roads[rnd.Next(0, _roads.Count-1)], transform.position, Quaternion.identity);
   }

   public void Spanw()
   {
       Vector3 position = new Vector3(0, 0, _road.transform.position.z + _roadLenght);
       GenerateTile();
   }
}
