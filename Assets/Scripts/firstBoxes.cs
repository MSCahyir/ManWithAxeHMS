using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstBoxes : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x <= -9.7)
        {
            Destroy(gameObject);
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
