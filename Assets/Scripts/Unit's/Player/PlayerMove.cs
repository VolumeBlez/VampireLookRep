
using UnityEngine;

public class PlayerMove
{
    private Rigidbody2D _rb;
    private Animator _anim;
    private Vector2 _movement;
    private Vector2 _previousInput;
    private bool _isMoving;

    public void InitMove(Rigidbody2D rb, Animator anim) 
    {
        this._rb = rb;
        this._anim = anim;
    }

    public void SetMove(Vector2 direction ) => _previousInput = direction;

    public void ResetMove() => _previousInput = Vector2.zero;

    public void MoveInput()
    {
        _movement.x = _previousInput.x;
        _movement.y = _previousInput.y;

        _anim.SetFloat("x", _movement.x);
    }

    public void Move(float speedMove)
    {
        _rb.MovePosition(_rb.position + _movement * speedMove * Time.fixedDeltaTime);
    }
}
