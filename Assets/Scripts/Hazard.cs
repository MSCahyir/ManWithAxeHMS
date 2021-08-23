using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private GameObject player;
    public Rigidbody2D hazardRb;
    bool isForced = false;
    Vector3 temp;

    public float force;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if(!isForced && player)
        {
            temp = new Vector3(-10, 0, 0);
            Debug.Log("Temp" + temp);
            hazardRb.AddForce(temp * force, ForceMode2D.Impulse);
            isForced = true;
        }
        
        if (transform.position.x <= -12.7)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Player" || collision.gameObject.tag == "Box")
        {
            Destroy(gameObject);
            if (collision.gameObject.tag == "Player")
                Destroy(collision.gameObject);
        }
    }

}
