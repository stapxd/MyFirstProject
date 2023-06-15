using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DestroyEnemy : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private GameObject bullet;

    //public Text enemyText;
    //public Text playerLVText;

    private EnemyCountText CountAndLives;

    //[SerializeField] private int count = 20;
    //[SerializeField] private int playerLives = 3;

    private void Awake()
    {
        //enemyText = GameObject.FindGameObjectWithTag("EnemiesCountText").GetComponent<Text>();
        //playerLVText = GameObject.FindGameObjectWithTag("PlayerLVText").GetComponent<Text>();

        CountAndLives = GameObject.FindGameObjectWithTag("EnemiesCountText").GetComponent<EnemyCountText>();
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            speed = 14f;
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            CountAndLives.enemyCount -= 1;
        }
        else if (collision.gameObject.CompareTag("Barier"))
        {
            Destroy(gameObject);
            CountAndLives.playerLives -= 1;
            Debug.Log("Barier");
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            CountAndLives.playerLives -= 1;
            Debug.Log("Player");
        }
    }



}
