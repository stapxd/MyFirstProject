using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesAndCountEnemy : MonoBehaviour
{
    public static int countEnemy;
    public static int playerLV;

    private void Start()
    {
        countEnemy = 20;
        playerLV = 3;
    }

}
