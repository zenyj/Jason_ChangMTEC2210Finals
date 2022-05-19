using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public float speed;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float xMove = Input.GetAxisRaw("Horizontal");


        float xMovement = xMove * speed * Time.deltaTime;


        transform.Translate(xMovement, 0, 0);
        //transform.position = new Vector3(transform.position.x + xMovement, transform.position.y , transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {



        if (collision.gameObject.tag == "Enemy")        
        {

            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "Enemy2")
        {

            Destroy(gameObject);
        }


    }
}
