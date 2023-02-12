
using UnityEngine;

public class Player : Unit
{
    [SerializeField] private PlayerData _data;

    public PlayerData Data => _data;

    public override void UnitInit()
    {
        _data.DataInit();
        
        _unitHealth = new Health(_data.MaxHealth.Value);
    }
}
