using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private EnemyAndFriends _enemy, _friends;
    [SerializeField] private TextMeshProUGUI _hp, _kill, _save;
    
    private int fullHp = 100, enemyStrike = 20, treatment = 10, killEnemys, saveFriends;
    private int score = 1000;
    private int enemyScore = 50, friendsScore = 30;

    private void Update()
    {
        //OnCheckEnemy();
        UpdateUI();
        LimitUI();
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
