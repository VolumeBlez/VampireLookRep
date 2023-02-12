using System.Collections.Generic;
using UnityEngine;

public class UnitStat
{
    private float _baseValue;
    private readonly List<StatModifier> _modifiers;

    public float Value { get { return CalculateValue(); } }

    public UnitStat(float baseValue)
    {
        this._baseValue = baseValue;
        _modifiers = new();
    }

    public void AddModifier(StatModifier mod) 
    {
        _modifiers.Add(mod);
    }

    public bool TryRemoveModifier(StatModifier mod)
    {
        return _modifiers.Remove(mod);
    }


    public float CalculateValue()
    {
        float _finalValue = _baseValue;

        foreach (var mod in _modifiers)
        {
            _finalValue += mod.Value;
        }

        return (float)Mathf.Round(_finalValue);
    }
}
