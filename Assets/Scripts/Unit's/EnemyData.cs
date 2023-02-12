
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private float _attackDamage;
    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _maxHealth;
    

    public UnitStat AttackDamage;
    public UnitStat WalkSpeed;
    public UnitStat MaxHealth;

    public virtual void DataInit()
    {
        AttackDamage = new UnitStat(_attackDamage);
        WalkSpeed = new UnitStat(_walkSpeed);
        MaxHealth = new UnitStat(_maxHealth);
    }
}
