using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintScore : MonoBehaviour
{
    private Text _scoreCountText;

    private void Start()
    {
        _scoreCountText = GetComponent<Text>();
    }

    private void Update()
    {
        _scoreCountText.text = GameManager.Instance.Score.ToString();
    }
}
