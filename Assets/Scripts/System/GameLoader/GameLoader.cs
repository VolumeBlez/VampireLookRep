
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private EnemySpawner _spawner;
    
    private void Awake() 
    {
        player.GetComponent<Player>().UnitInit();
    }

    private void Start() 
    {
        _spawner.Init(player.transform);
    }
}
