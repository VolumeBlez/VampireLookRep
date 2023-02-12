
using UnityEngine;

public class SpeedModifier : MonoBehaviour
{
    [SerializeField] private float _modifyValue = 2f;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.TryGetComponent(out Player player))
        {
            PlayerStatsModify.Instance.StatModify(player.Data.WalkSpeed, new StatModifier(_modifyValue));
        }
    }
}
