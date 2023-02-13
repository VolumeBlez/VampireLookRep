
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponControl : MonoBehaviour
{
    private readonly List<BaseWeapon> _weapons = new();

    public void AddWeapon(BaseWeapon weapon)
    {
        _weapons.Add(weapon);
    }

    void LateUpdate()
    {
        if(_weapons.Count == 0) return;
        foreach (var weapon in _weapons)
        {
            weapon.Attack();
        }
    }
}
