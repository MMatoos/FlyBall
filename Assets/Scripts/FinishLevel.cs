using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    private GameController _gameController;

    void Start()
    {
        _gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Ball"))
        {
            _gameController.LoadLevel();
            _gameController.LoadPlayer();
        }
    }
}
