
using UnityEngine;

public class WeaponAdder : MonoBehaviour
{
    [SerializeField] private GameObject _weaponPrefabToSet;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Player>() != null)
        {
            SetWeapon(other.transform);
        }
    }



    public void SetWeapon(Transform attachTarget)
    {
        var weapon = Instantiate(_weaponPrefabToSet, attachTarget.position, Quaternion.identity,  attachTarget);
        _weaponPrefabToSet.SetActive(true);
    }
}
