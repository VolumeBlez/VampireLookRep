
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    [SerializeField] private GameObject playerPref;
    [SerializeField] private GameObject enemyPref;
    
    private void Awake() 
    {
        playerPref.GetComponent<Player>().UnitInit();
    }

    private void Start() 
    {
        var enemy = Instantiate(enemyPref, Vector2.zero, Quaternion.identity);
        enemy.GetComponent<EnemyLoader>().EnemyInit(playerPref.transform);
    }
}
