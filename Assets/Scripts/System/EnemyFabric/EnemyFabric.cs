
using System.Collections.Generic;
using UnityEngine;

public class EnemyFabric : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField, Min(1)] private int _amountToPool = 1;

    public readonly List<GameObject> pooledEnemy = new();


    public void Init()
    {
        GameObject enemyVar;
        

        for (int i = 0; i < _amountToPool; i++)
        {
            enemyVar = Instantiate(_enemyPrefab, this.transform.position, Quaternion.identity, this.transform);
            enemyVar.SetActive(false);
            pooledEnemy.Add(enemyVar);
        }

        
    }

    public GameObject GetPooledEnemy() 
    {
        for (int i = 0; i < pooledEnemy.Count; i++)
        {
            if(!pooledEnemy[i].activeInHierarchy)
            {
                return pooledEnemy[i];
            }
        }
        return null;
    }


    

    

}
