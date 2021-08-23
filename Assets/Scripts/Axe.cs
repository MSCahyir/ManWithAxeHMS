using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public float force;
    public float delay;

    Rigidbody2D axeRb;
    public GameObject axeGo;
    private GameObject PlayerGo;
    bool isAddedForce = false;
    void Start()
    {
        PlayerGo = GameObject.FindGameObjectWithTag("Player");
        axeRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(!isAddedForce && PlayerGo)
        {
            axeRb.transform.position = PlayerGo.transform.position + new Vector3(-1,0.06f,0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !isAddedForce)
        {
            isAddedForce = true;
            axeRb.gravityScale = 1;
            axeRb.AddForce(new Vector2(1, 1) * force, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Box")
        {
            Destroy(gameObject);
            if (collision.gameObject.tag == "Enemy")
                Destroy(collision.gameObject);
        }

        if (collision == PlayerGo.gameObject.GetComponent<BoxCollider2D>())
            Debug.Log("Burada");
    }


}
