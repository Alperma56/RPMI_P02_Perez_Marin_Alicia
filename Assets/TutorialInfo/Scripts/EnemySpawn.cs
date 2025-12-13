using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawnPoint;
    public int spawnStart;
    public int spawnRepeate;

    private void Start()
    {
        InvokeRepeating("InstantiateEnemy", spawnStart, spawnRepeate);
      
    }

    private void InstantiateEnemy()
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }

    
}
