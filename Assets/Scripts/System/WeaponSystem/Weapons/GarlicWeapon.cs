
using UnityEngine;

public class GarlicWeapon : BaseWeapon
{
    [SerializeField] private CircleCollider2D _colliderWeapon;
    [SerializeField] private LayerMask enemyLayer;
    public override void Attack() 
    {
        Collider2D[] enemys = Physics2D.OverlapCircleAll(transform.position, _colliderWeapon.radius+2, enemyLayer);
        foreach (var enemy in enemys)
        {
            if(enemy.TryGetComponent(out Enemy enemyUnit))
            {
                enemyUnit._unitHealth.TakeDamage(Damage);
                Debug.Log(enemyUnit._unitHealth.CurrentHealth);
            }
        }
    }

    public override void UpgradeWeapon(BaseWeapon weapon, float upgradeDamagePoints)
    {
        base.UpgradeWeapon(weapon, upgradeDamagePoints);
        Destroy(weapon.gameObject);
    }

}
