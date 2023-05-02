
using UnityEngine;

public class Enemy : Unit
{
    [SerializeField] private EnemyData _data;
    [SerializeField] private DamageShowUp _showUp;

    public Health _unitHealth;
    public EnemyData Data => _data;

    public EnemyDestroy EnemyDestroy;

    public override void UnitInit()
    {
        _data.DataInit();
        
        _unitHealth = new Health(_data.MaxHealth.Value);
        EnemyDestroy = new(_unitHealth, this.gameObject);

        _showUp.Init(_unitHealth);

    }
}
