using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private EnemyCountText Lives;
    string DeathScene = "DeathScene";

    private void Awake()
    {
        Lives = GameObject.FindGameObjectWithTag("EnemiesCountText").GetComponent<EnemyCountText>();
    }


    private void Update()
    {
        if(Lives.playerLives <= 0)
        {
            
            SceneManager.LoadScene(DeathScene);

        }
    }



}
