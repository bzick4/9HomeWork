using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;
    private PoolGame pool;
    [SerializeField] private MoveWhiteBall whiteBall;

    private int totalScore;

    private void Start()
    {
        whiteBall.StopMovement();
    }

    public void ButtonStartPool()
    {
        whiteBall.StartMovement();
    }
    private void Update()
    {
        UpdateUi();
    }

    
    private void UpdateUi()
    {
        _score.text = totalScore.ToString();
    }

    private void OnEnable()
    {
        PoolGame.BallDown += OnBallDown;
    }
    private void OnBallDown()
    {
        totalScore++;
    }
}
