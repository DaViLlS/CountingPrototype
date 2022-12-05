using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCounter : MonoBehaviour
{
    public int count;
    private ScoreViewer _scoreViewer;

    private void Start()
    {
        count = 0;
        _scoreViewer = GameObject.Find("Canvas").GetComponent<ScoreViewer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        count++;
        _scoreViewer.ShowScore(count);
        Destroy(other.gameObject);
    }
}
