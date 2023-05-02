using System;
using UnityEngine;

public class Health
{
    public Action<float> OnHealthChanged;

    public Health(float maxHealth)
    {
        this._maxHealth = maxHealth;
        CurrentHealth = _maxHealth;
    }

    public  float CurrentHealth 
    {
        get => _currentHealth;

        set
        {
            _currentHealth = Mathf.Clamp(value, 0f, _maxHealth);
            OnHealthChanged?.Invoke(_currentHealth);
        }
    }

    private float _maxHealth;
    private float _currentHealth;

    public float MaxHealth => _maxHealth;

    public void Heal(float value)
    {
        if(value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        CurrentHealth += value;
    }

    public void TakeDamage(float damage)
    {
        if(damage < 0)
            throw new ArgumentOutOfRangeException(nameof(damage));

        CurrentHealth -= damage;
    }

}
