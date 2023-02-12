
using UnityEngine;

public class EnemyLoader : MonoBehaviour
{
    [SerializeField] private EnemyControl _enemyControl;
    [SerializeField] private Enemy _enemyUnit;

    public void EnemyInit(Transform target)
    {
        _enemyUnit.UnitInit();
        _enemyControl.EnemyControlInit(target, _enemyUnit);
    }
}
