using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("AXIS")]
    [SerializeField] private float horizontal;
    [SerializeField] private float vertical;
    
    [Header("ATRIBUTES")]
    [SerializeField] private float walkSpeed;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(horizontal * walkSpeed, vertical * walkSpeed);
    }
}
