
using UnityEngine;

public class BibleWeapon : BaseWeapon
{
    [SerializeField] private CircleCollider2D _colliderWeapon;
    [SerializeField] private LayerMask enemyLayer;
    [SerializeField] float radius = 2f;
    [SerializeField] float angularSpeed = 2f;
 
    float positionX, positionY, angle = 0f;
    private Transform center;

    private void Start() 
    {
        center = GetComponentInParent<Player>().transform;
    }
    private void Update() 
    {
        positionX = center.position.x + Mathf.Cos(angle) * radius;
        positionY = center.position.y + Mathf.Sin(angle) * radius;
        transform.position = new Vector2(positionX, positionY);
        angle = angle + Time.deltaTime * angularSpeed;
 
        if (angle >= 360f)
        {
            angle = 0f;
        }
    }

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
        positionX = center.position.x + Mathf.Cos(angle) * radius + 180f;
        positionY = center.position.y + Mathf.Sin(angle) * radius + 180f;

        weapon.transform.position = new Vector2(-positionX, -positionY);
    }
}
