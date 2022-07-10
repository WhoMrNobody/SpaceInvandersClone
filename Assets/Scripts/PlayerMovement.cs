using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    public float moveSpeed;
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    void Start()
    {
        _rigidbody=GetComponent<Rigidbody2D>();
        _animator=GetComponent<Animator>();
    }

   
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(h, v);

        _rigidbody.velocity= direction.normalized * moveSpeed;

        _animator.SetBool("isFlyingLeft", h < 0);
        _animator.SetBool("isMovingTop", v > 0);
        _animator.SetBool("isFlyingRight", h > 0);
    }
}
