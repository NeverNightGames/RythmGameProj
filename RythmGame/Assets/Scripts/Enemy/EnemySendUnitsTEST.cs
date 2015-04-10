using UnityEngine;
using System.Collections;

public class EnemySendUnitsTEST : MonoBehaviour
{

    public GameObject unitOBJ;


    private GameObject Lane2OBJ;




    // Use this for initialization
    void Start()
    {
        Lane2OBJ = GameObject.Find("Lane 2");

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lanepos = new Vector2(Lane2OBJ.transform.position.x, Lane2OBJ.transform.position.y + 10);


        if (Input.GetKeyDown(KeyCode.Space))
        {

            //Debug.Log(Random.Range(1, 4));

            Instantiate(unitOBJ, lanepos, Quaternion.identity);

        }

    }
}
