
using UnityEngine;

public class Player : Unit
{
    [SerializeField] private PlayerData _data;
    [SerializeField] private Transform _weaponHandler;
    
    public Health _unitHealth;
    public PlayerData Data => _data;
    public Transform WeaponHandler => _weaponHandler;

    public override void UnitInit()
    {
        _data.DataInit();
        
        _unitHealth = new Health(_data.MaxHealth.Value);
    }
}
