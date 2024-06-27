using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class GenerationRoad : MonoBehaviour
{
   [SerializeField] private GameObject _roadPrefab;
   [SerializeField] private float _speed;
   [SerializeField] private int _maxCount;
   [SerializeField] private List<Tile> _tiles = new List<Tile>();

   private void Start()
   {
      _tiles.First().speed = _speed;
      for (int i = 0; i < _maxCount; i++)
      {
         GenerateTile();
      }
   }

   private void Update()
   {
      if (_tiles.Count < _maxCount)
      {
         GenerateTile();
      }
   }

   private void GenerateTile()
   {
      GameObject newTileObject = Instantiate(_roadPrefab, _tiles.Last().transform.position + Vector3.forward *_roadPrefab.transform.localScale.z, Quaternion.identity);
      Tile newTile = newTileObject.GetComponent<Tile>();
      newTile.speed = _speed;
      _tiles.Add(newTile);
   }

   private void OnTriggerEnter(Collider other)
   {
      _tiles.Remove(other.GetComponent<Tile>());
      Destroy(other.gameObject);
   }
}
