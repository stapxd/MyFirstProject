using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject bullet;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z+1.5f), Quaternion.identity);
        }

    }
}
