using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnInterval = 1f;

    public float minX;
    public float maxX;

    void Start()
    {
        StartCoroutine(SpawnerCoroutine());
    }

    void Update()
    {

    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), transform.position.y, 0);

        GameObject enemyInstance = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    IEnumerator SpawnerCoroutine()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
