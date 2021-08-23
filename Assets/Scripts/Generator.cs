using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject loseScreen;

    public GameObject box;
    public GameObject enemy;
    public float generateTime;
    private int count;
    private int enemyRnd;
    private Vector3 rndPosition;

    void Start()
    {
        InvokeRepeating("addBox", 0.0f, generateTime);
    }


    private void Update()
    {
        bool playerAlive = GameObject.FindGameObjectWithTag("Player");
        if (!playerAlive)
        {
            loseScreen.SetActive(true);
        }
    }
    void addBox()
    {
        //enemyRnd = Random.Range(1, 3);
        //count++;
        //if(count % 2 == enemyRnd)
        //{

        //}

        float boxRnd = Random.Range(2.5f, -4f);

        rndPosition = new Vector3(11.7f, boxRnd, transform.position.z);

        enemy.transform.position = transform.position;

        Instantiate(enemy, rndPosition + new Vector3(0,1.1f,0), enemy.transform.rotation);
        Instantiate(box, rndPosition, transform.rotation);
    }
}
