using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIfunctionsmanager : MonoBehaviour
{
    private int _gameSceneIndex = 1;

    public void StartScene(int index)
    {
        if(index == _gameSceneIndex)
        {
            GameManager.Instance.NillifyScoreValue();
        }
        SceneManager.LoadScene(index);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
