
using UnityEngine;

public class Enemy : Unit
{
    [SerializeField] private EnemyData _data;

    public EnemyData Data => _data;

    public override void UnitInit()
    {
        _data.DataInit();
        
        _unitHealth = new Health(_data.MaxHealth.Value);
    }
}
