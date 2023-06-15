using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreatingEnemy : MonoBehaviour
{

    [SerializeField] private GameObject point1;
    [SerializeField] private GameObject point2;
    [SerializeField] private GameObject point3;

    [SerializeField] private GameObject enemy;

    private int ammointOfgEnemies = 30;


    private void Start()
    {
        StartCoroutine(CoroutineCreating());
    }

    private IEnumerator CoroutineCreating()
    {


        //int ranNum = Random.Range(1,122);
        //if (ranNum % 11 == 0)
        //{
        //    int ranNum2 = Random.Range(1, 20);
        //    if (ranNum2 == 5)
        //    {
        //        Instantiate(enemy, new Vector3(point3.transform.position.x, point3.transform.position.y, point3.transform.position.z), Quaternion.identity);
                
        //    }
        //    else if (ranNum2 == 7 )
        //    {
        //        Instantiate(enemy, new Vector3(point1.transform.position.x, point1.transform.position.y, point1.transform.position.z), Quaternion.identity);
                
        //    }
        //    else if (ranNum2 == 9)
        //    {
        //        Instantiate(enemy, new Vector3(point2.transform.position.x, point2.transform.position.y, point2.transform.position.z), Quaternion.identity);
                
        //    }
        //}

        for(int i = 0; i < ammointOfgEnemies; i++)
        {
            int ranNum2 = Random.Range(1, 4);
            if (ranNum2 % 3 == 0)
            {
                Instantiate(enemy, new Vector3(point3.transform.position.x, point3.transform.position.y, point3.transform.position.z), Quaternion.identity);

            }
            else if (ranNum2 % 3 == 1)
            {
                Instantiate(enemy, new Vector3(point1.transform.position.x, point1.transform.position.y, point1.transform.position.z), Quaternion.identity);

            }
            else if (ranNum2 % 3 == 2)
            {
                Instantiate(enemy, new Vector3(point2.transform.position.x, point2.transform.position.y, point2.transform.position.z), Quaternion.identity);

            }

            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                yield return new WaitForSeconds(1f);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                yield return new WaitForSeconds(0.5f);
            }
            


        }

    }
}
