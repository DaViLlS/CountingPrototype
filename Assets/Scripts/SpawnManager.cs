using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 1;
    private float interval = 4;
    
    private static Vector3 RightUpPoint = new Vector3(-9.138f, 7.01f, -3.413f);
    private static Vector3 LeftUpPoint = new Vector3(9.138f, 7.01f, -3.413f);
    private static Vector3 RightDownPoint = new Vector3(9.289f, 4.75f, -3.413f);
    private static Vector3 LeftDownPoint = new Vector3(-9.289f, 4.75f, -3.413f);

    private Vector3[] arrayOfPoints = { RightUpPoint, LeftUpPoint, RightDownPoint, LeftDownPoint };

    [SerializeField] private GameObject eggPrefab;

    private void Start()
    {
        InvokeRepeating("SpawnEgg", startDelay, interval);
    }

    private void SpawnEgg()
    {
        int point = Random.Range(0, 3);
        
        if (GameOver.isGameOver == false)
            Instantiate(eggPrefab, arrayOfPoints[point], eggPrefab.transform.rotation);
    }
}
