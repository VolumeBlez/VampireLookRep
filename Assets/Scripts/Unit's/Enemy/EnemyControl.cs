
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    private Enemy _enemy;
    
    private EnemyMove _enemyMove;

    public void EnemyControlInit(Transform target, Enemy enemy) 
    {
        this._enemyMove = new EnemyMove(_rb, target);
        this._enemy = enemy;
    }

    private void Update() 
    {
        _enemyMove.Move(_enemy.Data.WalkSpeed.Value);
    }

    private void LateUpdate() 
    {
        //_enemyMove.Look();
    }
}
