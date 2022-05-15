using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy2Movement : MonoBehaviour
{
    public float speed = 5;


    void Update()
    {
        float yValue = speed * Time.deltaTime;
        transform.Translate(0, -yValue, 0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Score.scoreValue += 10;
            Destroy(gameObject);
        }


        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Game Over");
            Debug.Log("Game Over");
        }

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
            Score.scoreValue -= 10;
        }

    }
}

