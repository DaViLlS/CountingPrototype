using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerBody;
    [SerializeField] private float speedMovement;

    private void Update()
    {
        float deltaX = Input.GetAxis("Horizontal");
        
        if (GameOver.isGameOver == false)
            transform.Translate(Vector3.left * Time.deltaTime * deltaX * speedMovement);
    }
}
