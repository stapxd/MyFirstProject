using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody playerRB;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        transform.position = new Vector3(Input.GetAxisRaw("Horizontal") * 4f, transform.position.y, 0f);
    }
}
