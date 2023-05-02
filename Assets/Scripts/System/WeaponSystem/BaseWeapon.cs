
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{
    [SerializeField] private float _coolDown;
    private bool _isWeaponReady = true;

    public float CoolDown => _coolDown;
    public bool IsWeaponReady { get => _isWeaponReady; set { _isWeaponReady = value; } }
    public virtual void Attack() {}
}
