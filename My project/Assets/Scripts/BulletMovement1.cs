using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement1 : MonoBehaviour
{

    [SerializeField] private GameObject bullet;

    [SerializeField] private float force = 5f;

    void Update()
    {

        bullet.transform.Translate(Vector3.forward * force * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Barier"))
        {
            Destroy(gameObject);
        }
    }
}
