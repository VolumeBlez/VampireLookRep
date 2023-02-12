
using UnityEngine;

public class EnemyMove
{
    private Rigidbody2D _rb2D;
    private Transform _targetTransform;
    public EnemyMove(Rigidbody2D rb, Transform target)  
    {
        this._rb2D = rb;
        this._targetTransform = target;
    }

    public void Look() 
    {
        // not yet
    }

    public void Move(float _moveSpeed) 
    {
        _rb2D.transform.position = Vector2.MoveTowards(_rb2D.transform.position,
            new Vector2(_targetTransform.position.x, _targetTransform.position.y),
             _moveSpeed *  Time.deltaTime);
    }
}
