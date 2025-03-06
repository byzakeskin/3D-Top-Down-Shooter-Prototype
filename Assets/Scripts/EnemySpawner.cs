using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints; //inspector �zerinde istedi�imiz kadar spawn noktas� a�abilme
    [SerializeField]
    private float spawnTime;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, spawnTime); //spawner�n belirli bir zaman aral���nda �al��mas� ve oyun ba�lad�ktan belirli bir s�re sonra spawn etmeye ba�lamas�
    }

    private void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length); //olu�turdu�umuz spawnerlardan rastgele bir �ekilde d��man spwan edilmesi
        Transform spawnPoint = spawnPoints[spawnIndex];

        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
