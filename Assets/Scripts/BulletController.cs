using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float tickSpeed = 3f;


    // Start is called before the first frame update
    void Start()
    {
        var rigidBody = gameObject.GetComponent<Rigidbody2D>();

        rigidBody.velocity = Vector3.up * tickSpeed;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            //Destroy the bullet
            Destroy(gameObject);

            collision.GetComponent<EnemyController>().Kill();
        }
    }
}
