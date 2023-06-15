using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameMenu : MonoBehaviour
{

    public Button startGame;

    string Lvl1 = "Level 1";

    private void Start()
    {
        Button btn = startGame.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    private void TaskOnClick()
    {
        SceneManager.LoadScene(Lvl1);
    }



}
