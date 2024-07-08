using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SupermanManager : MonoBehaviour
{ 
    [SerializeField] private Move _movement;
    [SerializeField] private GameObject _panelWin, _panelLose;
    [SerializeField] private TextMeshProUGUI _hp, _kill, _save;
    private EnemyAndFriends _enemy, _friends;

    private int fullHp = 100, enemyStrike = 20, treatment = 10, killEnemys, saveFriends;
    private int score = 1000;
    private int enemyScore = 30, friendsScore = 20;
    

    private void Start()
    {
        _movement.StopMovement();
    }
    public void ButtonStartMovement()
    {
       _movement.StartMovement();
    }
    private void Update()
    {
        UpdateUI();
        LimitUI();
        PanelWin();
        PanelLose();
    }
    public void Restart()
    {
        _panelLose.SetActive(false);
        _panelWin.SetActive(false);
        ButtonStartMovement();
        fullHp = 100;
        killEnemys = 0;
        saveFriends = 0;
        UpdateUI();
    }
    private void UpdateUI()
    {
        _hp.text = fullHp.ToString();
        _kill.text = killEnemys.ToString();
        _save.text = saveFriends.ToString();
    }
    private void LimitUI()
    {
        int minValue = 0;
        int maxValue = 1000;
        fullHp = Mathf.Clamp(fullHp, minValue, 100);
        killEnemys = Mathf.Clamp(killEnemys, minValue, maxValue);
        saveFriends = Mathf.Clamp(saveFriends, minValue, maxValue);
    }

    public void PanelLose()
    {
        
        if (fullHp <= 0)
        {
            Time.timeScale = 0;
            _panelLose.SetActive(true);
        }
    }
    public void PanelWin()
    {
        if (killEnemys >= enemyScore || saveFriends >= friendsScore)
        {
            Time.timeScale = 0;
            _panelWin.SetActive(true);
        }
    }
    private void OnEnable()
    {
        EnemyAndFriends.EnemyDisappeared += OnEnemyDisappeared;
        EnemyAndFriends.FriendsSave += OnFriendsSave;
    }
    private void OnDisable()
    {
        EnemyAndFriends.EnemyDisappeared -= OnEnemyDisappeared;
        EnemyAndFriends.FriendsSave -= OnFriendsSave;
    }
    private void OnEnemyDisappeared()
    {
        fullHp -= enemyStrike;
        killEnemys++;
        UpdateUI();
    }
    private void OnFriendsSave()
    {
        fullHp += treatment;
        saveFriends++;
        UpdateUI();
    }
}
