using UnityEngine;

public class PlayerStatsModify : MonoBehaviour
{
    public static PlayerStatsModify Instance;

    private void Awake()  
    {
        if(Instance == null)
            Instance = this;
    }
    
    public void StatModify(UnitStat statToModify, StatModifier mod)
    {
        if(mod.Value == 0) return;
        statToModify.AddModifier(mod);
    }
}
