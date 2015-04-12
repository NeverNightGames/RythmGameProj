using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealthTEST : MonoBehaviour
{

    public Slider enemyHealthSliderOBJ;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealthSliderOBJ.value == 0)
        {
            print("WIN!");
        }


    }
}
