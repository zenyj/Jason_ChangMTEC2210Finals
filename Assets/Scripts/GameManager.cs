using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{

    public GameObject EnemyPrefab;
    public GameObject EnemyPrefab2;
    public Transform[] SpawnPoints;
    public Transform[] SpawnPoints2;
    public float SpawnSpeed = 2.0f;
    public float SpawnSpeed2 = 2.0f;

    public TextMeshPro timerText;
   
  


    // Start is called before the first frame update
    void Start()
    {
        



        {
            InvokeRepeating("SpawnEnemy", 1.0f, SpawnSpeed);

           
            InvokeRepeating("SpawnEnemy2", 1.0f, SpawnSpeed2);
                
            
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
        


        Enemy.GetComponent<EnemyMovement>().speed = Random.Range(1.0f, 4.0f);
       




    }
    void SpawnEnemy2()
    {

        
        int index2 = Random.Range(0, SpawnPoints2.Length);
        
        Vector3 spawnPos2 = SpawnPoints[index2].position;
        
        GameObject Enemy2 = Instantiate(EnemyPrefab2, spawnPos2, Quaternion.identity);


        
        Enemy2.GetComponent<Enemy2Movement>().speed = Random.Range(5.0f, 7.0f);




    }

}
