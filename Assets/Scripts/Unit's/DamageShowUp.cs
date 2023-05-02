
using System.Collections;
using UnityEngine;

public class DamageShowUp : MonoBehaviour
{
    [SerializeField] private Color _damageColor = Color.red;
    [SerializeField] private SpriteRenderer _spriteRend;

    private float _damageTimeSec = 1f;
    private Color _defaultColor;

    private Health _health = null;

    public void Init(Health health) 
    {
        this._health = health;

        health.OnHealthChanged += Show;
        _defaultColor = _spriteRend.color;
    }

    public void Show(float currentHealth)
    {
        Debug.Log("Show");
        StopCoroutine(StartEffectCoroutine());

        if(currentHealth == _health.MaxHealth)
        {
            SetDefaultColor();
            return;
        }

        if(currentHealth > 10)
            StartCoroutine(StartEffectCoroutine());
    }

    private void SetDefaultColor()
    {
        _spriteRend.color = _defaultColor;
    }

    private IEnumerator StartEffectCoroutine()
    {
        float time = 0;
        float step = 1f / _damageTimeSec;
 
        while (time < _damageTimeSec)
        {
            time += Time.deltaTime;
            _spriteRend.color = Color.Lerp(_damageColor, _defaultColor, step * time);
 
            yield return null;
        }
    }
}
