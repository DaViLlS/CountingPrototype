using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnManager;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject startUI;
    public void StartGame()
    {
        Instantiate(spawnManager);
        gameUI.SetActive(true);
        startUI.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
