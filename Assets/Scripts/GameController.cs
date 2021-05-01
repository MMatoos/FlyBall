using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject[] _levelArray;
    private GameObject _actualLevel;
    private int _levelIndex;

    private GameObject _ball;

    private bool _ended = false;
    [SerializeField] private TMP_Text tryAgain;

    void Start()
    {
        _actualLevel = GameObject.FindGameObjectWithTag("Level");
        _ball = GameObject.FindGameObjectWithTag("Ball");
        _levelIndex = _actualLevel.GetComponent<LevelController>().levelIndex;
    }

    private void Update() 
    {
        //Checking if game has ended, after clicking space - restarting level
        if (_ended && Input.GetKeyDown("space"))
        {
            _ball.SetActive(true);
            _ended = false;
            tryAgain.enabled = false;
            LoadPlayer();
        }
    }

    //Destroying actual level, increasing index and instantiating new level from the array
    public void LoadLevel()
    {
        Destroy(_actualLevel);
        _levelIndex = _levelIndex + 1;

        Instantiate(_levelArray[_levelIndex], new Vector3(0, 0, 0), Quaternion.identity);
        _actualLevel = GameObject.FindGameObjectWithTag("Level");
    }

    //Loading player, changing its position to start
    public void LoadPlayer()
    {
        _ball.GetComponent<Rigidbody>().transform.position = new Vector3(0, 0, 0);
    }

    //Displaying retry message
    public void EndGame()
    {
        _ended = true;
        tryAgain.enabled = true;
    }
}
