using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    public GameObject EnemyPrefab;
    public Transform[] SpawnPoints;
    public float SpawnSpeed = 2.0f;



    // Start is called before the first frame update
    void Start()
    {
        

        {
            InvokeRepeating("SpawnEnemy", 1.0f, SpawnSpeed);
            
        }
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnEnemy()
    {

        int index = Random.Range(0, SpawnPoints.Length);
        Vector3 spawnPos = SpawnPoints[index].position;
        GameObject Enemy = Instantiate(EnemyPrefab, spawnPos, Quaternion.identity);


        Enemy.GetComponent<EnemyMovement>().speed = Random.Range(3.0f, 6.0f);




    }
}
