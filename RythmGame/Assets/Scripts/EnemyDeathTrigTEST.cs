﻿using UnityEngine;
using System.Collections;

public class EnemyDeathTrigTEST : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player Large")
        {
            GameObject.Find("Enemy").GetComponentInParent<EnemyHealthTEST>().enemyHealthSliderOBJ.value -= 1;
        }

        if (col.gameObject.tag == "Player Small")
        {
            GameObject.Find("Enemy").GetComponentInParent<EnemyHealthTEST>().enemyHealthSliderOBJ.value -= 1;
        }

        if (col.gameObject.tag == "Player Range")
        {
            GameObject.Find("Enemy").GetComponentInParent<EnemyHealthTEST>().enemyHealthSliderOBJ.value -= 1;
        }

        Destroy(col.gameObject);

    }
}
