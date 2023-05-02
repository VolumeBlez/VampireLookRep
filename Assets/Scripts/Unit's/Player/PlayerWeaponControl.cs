
using System.Collections;
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
            if(weapon.IsWeaponReady)
            {
                weapon.Attack();
                StartCoroutine(ReloadWeapon(weapon, weapon.CoolDown));
            }
        }
    }

    IEnumerator ReloadWeapon(BaseWeapon weapon, float coolDown)
    {
        weapon.IsWeaponReady = false;
        yield return new WaitForSeconds(coolDown);
        weapon.IsWeaponReady = true;
    }
}
