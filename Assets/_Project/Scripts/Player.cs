using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _playerNumber;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpStrength;
    [SerializeField] private Rigidbody2D _rb;

    private float h;
    private bool _isJumping;

    void Start()
    {
        if( _rb == null )
            _rb = GetComponent<Rigidbody2D>();
        if (_rb == null)
            Debug.LogError($"Nessuna componente RigidBody2D trovata per l'oggetto {gameObject.name}");
    }

    private void Update()
    {
        h = Input.GetAxis($"HorizontalP{_playerNumber}");

        if (Input.GetButtonDown($"JumpP{_playerNumber}"))
        {
            _isJumping = true;
        }
    }

    void FixedUpdate()
    {
        Vector2 direction = new Vector2(h * _speed, _rb.velocity.y);
        _rb.velocity = direction;

        if (_isJumping)
        {
            _rb.AddForce(Vector2.up * _jumpStrength, ForceMode2D.Impulse);
            _isJumping = false;
        }
    }
}
