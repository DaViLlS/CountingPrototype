using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    private TextMeshProUGUI _timeText;
    private float _time;
    private GameOver _gameOver;

    private void Start()
    {
        _gameOver = GameObject.Find("Game Manager").GetComponent<GameOver>();
        _timeText = GetComponent<TextMeshProUGUI>();
        _time = 60.0f;
    }

    private void Update()
    {
        if (GameOver.isGameOver == false && _time > 0)
        {
            _timeText.text = "Time: " + Convert.ToInt32(_time);
            _time -= Time.deltaTime;
        }
        else if (_time < 0)
        {
            _gameOver.EndGame();
        }
    }
        
}
