
using UnityEngine;

public class WeaponAdder : MonoBehaviour
{
    [SerializeField] private GameObject _weaponPrefabToSet;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent(out PlayerWeaponControl player))
        {
            SetUpWeapon(player.transform, player);
        }
    }



    public void SetUpWeapon(Transform attachTarget, PlayerWeaponControl weaponControlTarget)
    {
        var weapon = Instantiate(_weaponPrefabToSet, attachTarget.position, Quaternion.identity,  attachTarget);
        _weaponPrefabToSet.SetActive(true);

        weaponControlTarget.AddWeapon(weapon.GetComponent<BaseWeapon>());
    }
}
