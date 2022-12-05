using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreViewer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    public void ShowScore(int count)
    {
        scoreText.text = "Score: " + count;
    }
}
