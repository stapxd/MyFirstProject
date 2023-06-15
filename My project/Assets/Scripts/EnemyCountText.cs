using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCountText : MonoBehaviour
{

    public Text enemyText;
    public Text playerLivesText;

    public int enemyCount = 20;
    public int playerLives = 3;

    private void Update()
    {
        enemyText.text = "Enemies Remaining: " + enemyCount;
        playerLivesText.text = "Your lives: " + playerLives;

        if(enemyCount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


    }



}
