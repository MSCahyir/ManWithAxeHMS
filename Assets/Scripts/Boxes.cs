using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    public float speed;
    public GameObject enemy;
    // -9.7, 9.7 
    // 2.5, -2.5 
    void Start()
    {
    }

    void Update()
    {
        if(transform.position.x <= -12.7)
        {
            Destroy(gameObject);
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
