using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Cannon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Instantiate(Bullet, Cannon.position , Quaternion.identity);
           


        }
     
            
        
    }
}
