using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints; //inspector üzerinde istediðimiz kadar spawn noktasý açabilme
    [SerializeField]
    private float spawnTime;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, spawnTime); //spawnerýn belirli bir zaman aralýðýnda çalýþmasý ve oyun baþladýktan belirli bir süre sonra spawn etmeye baþlamasý
    }

    private void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length); //oluþturduðumuz spawnerlardan rastgele bir þekilde düþman spwan edilmesi
        Transform spawnPoint = spawnPoints[spawnIndex];

        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
