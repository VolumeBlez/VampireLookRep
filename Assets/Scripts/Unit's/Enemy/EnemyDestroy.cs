using System;
using UnityEngine;

public class EnemyDestroy
{
    private GameObject _objectToDestroy;
    public Action<EnemyDestroy> OnEnemyDie;

    private Health _health;

    public EnemyDestroy(Health health, GameObject objectToDestroy)
    {
        _health = health;
        this._objectToDestroy = objectToDestroy;
        health.OnHealthChanged += CheckHealthForDeath;
    }

    private void CheckHealthForDeath(float health) 
    {
        if(health <= 0)
            Die();
    }

    private void Die() 
    {

        OnEnemyDie?.Invoke(this);
        _objectToDestroy.SetActive(false);
        _health.CurrentHealth = _health.MaxHealth;
    }
}
