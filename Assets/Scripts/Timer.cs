using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int _gameplayTime;
    private Text _timerText;

    private void Start()
    {
        _timerText = GetComponent<Text>();
        _gameplayTime = 30;
        InvokeRepeating("CountTime", 1, 1);
    }

    private void Update()
    {
        _timerText.text = _gameplayTime.ToString();
    }

    private void CountTime()
    {
        _gameplayTime -= 1;
        if (_gameplayTime == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
