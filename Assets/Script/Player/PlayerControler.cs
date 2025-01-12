using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    Rigidbody2D _rb;

    public float MoveSpeed = 1.0f;
    public float MaxSpeedX = 1.0f;
    public float MaxSpeedY = 1.0f;

    int inputX, inputY;
    private bool _walkingDown;
    private bool _walkingRight;
    private bool _walkingLeft;
    private bool _walkingUp;

    public bool WalkingRight { get => _walkingRight; set => _walkingRight = value; }
    public bool WalkingLeft { get => _walkingLeft; set => _walkingLeft = value; }
    public bool WalkingUp { get => _walkingUp; set => _walkingUp = value; }
    public bool WalkingDown { get => _walkingDown; set => _walkingDown = value; }

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        inputX = (_walkingRight && _walkingLeft) ? 0 : ((_walkingRight ? 1 : 0) ^ (_walkingLeft ? -1 : 0));
        inputY = (_walkingUp && _walkingDown) ? 0 : ((_walkingUp ? 1 : 0) ^ (_walkingDown ? -1 : 0));
        MoveCharacter();
    }

    void MoveCharacter()
    {
        float _speedX = inputX * MoveSpeed, _speedY = inputY * MoveSpeed;
        _rb.velocity = new Vector2(_speedX, _speedY) * MoveSpeed;
    }


}
