using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverUI;
    public GameObject gameUI;

    private void Start()
    {
        isGameOver = false;
    }

    public void EndGame()
    {
        isGameOver = true;
        gameOverUI.SetActive(true);
        gameUI.SetActive(false);
    }
}
