using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _scoreValue;
    private int _countCoinsToAdd;
    private int _countCoinsToRemove;

    public GameObject FriendCreature { get; private set; }
    public GameObject EnemyCreature { get; private set; }
    public static GameManager Instance { get; private set; }
    public int Score
    {
        get
        {
            return _scoreValue;
        }
    }

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
            EnemyCreature = Resources.Load<GameObject>("Enemy");
            FriendCreature = Resources.Load<GameObject>("Friend");
            _countCoinsToAdd = 1;
            _countCoinsToRemove = 3;
            _scoreValue = 0;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoins()
    {
        _scoreValue += _countCoinsToAdd;
    }

    public void RemoveCoins()
    {
        if (_scoreValue >= _countCoinsToRemove)
        {
            _scoreValue -= _countCoinsToRemove;
        }
        else
        {
            _scoreValue = 0;
        }
    }

    public void NillifyScoreValue()
    {
        _scoreValue = 0;
    }
}
