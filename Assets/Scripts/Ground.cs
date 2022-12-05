using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private GameOver _gameOver;
    
        private void Start()
        {
            _gameOver = GameObject.Find("Game Manager").GetComponent<GameOver>();
        }
    
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Egg"))
            _gameOver.EndGame();
        }
}
