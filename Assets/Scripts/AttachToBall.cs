using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToBall : MonoBehaviour
{
    [SerializeField] private GameObject _ball;

    void Update()
    {
        if(_ball != null)
            this.transform.position = new Vector3(0, _ball.transform.position.y, 0);
    }
}
