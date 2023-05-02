using System;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{
    [SerializeField] private float _coolDown;
    private bool _isWeaponReady = true;

    public Type Type => GetType();
    public float Damage;
    public float CoolDown => _coolDown;
    public bool IsWeaponReady { get => _isWeaponReady; set { _isWeaponReady = value; } }
    public virtual void Attack() {}

    public virtual void UpgradeWeapon(BaseWeapon weapon, float upgradeDamagePoints)
    {
        Debug.Log("Upgrade Damage");
        this.Damage += upgradeDamagePoints;
    }

    
}
