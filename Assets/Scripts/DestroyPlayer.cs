using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    private GameController _gameController;

    void Start()
    {
        _gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    private void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            col.gameObject.SetActive(false);
            _gameController.EndGame();
        }
    }
}
