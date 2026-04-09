using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;   
    public float spawnInterval = 3f; 
    public int spawnCount = 5;
    public Transform rotateCenter;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnInterval);
        }

        Debug.Log("刷怪结束");
    }

    void SpawnEnemy()
    {
        if (SpawnManager.singleton.canSpawn)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            EnemyCircleMove ecm = enemy.GetComponent<EnemyCircleMove>();
            ecm.center = rotateCenter;

            Debug.Log("生成一个敌人");
        }
    }
}