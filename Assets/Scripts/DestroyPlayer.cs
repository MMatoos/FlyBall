using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    //private GameObject _player;

    void Start()
    {
        //_player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter(Collision col) {
        if (col.gameObject.CompareTag("Player"))
            Destroy(col.gameObject);
    }
}
