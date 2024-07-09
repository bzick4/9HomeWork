using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SupermanManager : MonoBehaviour
{
    [SerializeField] private Move _movement;
    private EnemyAndFriends _enemy, _friends;

    private void Start()
    {
        _movement.StopMovement();
    }

    public void ButtonStartMovement()
    {
        _movement.StartMovement();
    }

    public void Restart()
    {
       
        ButtonStartMovement();
        
    }

}