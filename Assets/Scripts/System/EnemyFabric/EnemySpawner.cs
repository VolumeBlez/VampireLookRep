
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyFabric _fabric;

    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _countEnemyOnMap;

    private Transform _target;

    public void Init(Transform target)
    {
        this._target = target;

        _fabric.Init();
        StartSpawn();
    }

    public void StartSpawn() 
    {
        for (int i = 0; i < _countEnemyOnMap; i++)
        {
            SpawnEnemyOnMap();
        }
    }

    public void EnemyDied(EnemyDestroy enemyDestroy)
    {
        enemyDestroy.OnEnemyDie -= EnemyDied;
        SpawnEnemyOnMap();
    }

    private void SpawnEnemyOnMap()
    {
        GameObject tmp = _fabric.GetPooledEnemy();

        tmp.transform.position = _spawnPoints[Random.Range(0, _spawnPoints.Length)].position;
        tmp.SetActive(true);
        tmp.GetComponent<EnemyLoader>().EnemyInit(_target);
        tmp.GetComponent<Enemy>().EnemyDestroy.OnEnemyDie += EnemyDied;
    }
}
