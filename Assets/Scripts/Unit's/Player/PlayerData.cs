
using UnityEngine;

[CreateAssetMenu(fileName = "Player data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private float _luck;
    [SerializeField] private float _startAttackDamage;
    [SerializeField] private float _startWalkSpeed;
    [SerializeField] private float _maxHealth;
    

    public UnitStat AttackDamage;
    public UnitStat WalkSpeed;
    public UnitStat MaxHealth;

    public UnitStat Luck;

    public void DataInit()
    {
        Luck = new UnitStat(_luck);
        AttackDamage = new UnitStat(_startAttackDamage);
        WalkSpeed = new UnitStat(_startWalkSpeed);
        MaxHealth = new UnitStat(_maxHealth);
    }
}
