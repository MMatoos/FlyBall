using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _sideSpeed;
    private float _horizontalInput;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rb.transform.position += Vector3.up * _jumpForce * Time.deltaTime;

        _horizontalInput = Input.GetAxis("Horizontal");
        _rb.transform.position += new Vector3(_horizontalInput, 0, 0) * _sideSpeed * Time.deltaTime;
    }
}
