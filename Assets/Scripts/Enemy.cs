using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;

    public GameObject player;
    public Rigidbody2D hazardRb;
    public GameObject hazard;

    public float speed;

    private float nextActionTime = 1.0f;
    public float period = 3f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (transform.position.x <= -11.7)
        {
            Destroy(gameObject);
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (Time.time > nextActionTime)
        {
            nextActionTime += Time.time;
            hazardRb.transform.position = transform.position + new Vector3(-0.9f, 0.3f, 10);

            Instantiate(hazard, hazardRb.transform.position, Quaternion.identity);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" )
        {
            Destroy(col.gameObject);
        }
    }

}
