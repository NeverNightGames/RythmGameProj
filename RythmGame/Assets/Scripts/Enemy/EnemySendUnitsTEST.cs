using UnityEngine;
using System.Collections;

public class EnemySendUnitsTEST : MonoBehaviour
{

    public GameObject smallUnitOBJ;

    public GameObject rangeUnitOBJ;

    public GameObject largeUnitOBJ;


    private GameObject Lane1OBJ;

    private GameObject Lane2OBJ;

    private GameObject Lane3OBJ;


    int rNUM;


    private float spawnClock;

    public float spawnTime;


    //public bool spawn;


    // Use this for initialization
    void Start()
    {
        Lane1OBJ = GameObject.Find("Lane 1");

        Lane2OBJ = GameObject.Find("Lane 2");

        Lane3OBJ = GameObject.Find("Lane 3");

    }

    // Update is called once per frame
    void Update()
    {

        spawnClock += Time.deltaTime;

        Vector2 lane1Pos = new Vector2(Lane1OBJ.transform.position.x, Lane1OBJ.transform.position.y + 10);

        Vector2 lane2Pos = new Vector2(Lane2OBJ.transform.position.x, Lane2OBJ.transform.position.y + 10);

        Vector2 lane3Pos = new Vector2(Lane3OBJ.transform.position.x, Lane3OBJ.transform.position.y + 10);



        // print(rNUM);

        //spawnClock += Time.deltaTime;

       // print(spawnClock);

        if (spawnClock >= spawnTime)
        {

            rNUM = Random.Range(1, 4);

            //print(rNUM);

            if (GameObject.Find("New Player Control").GetComponentInParent<NewPllayerControlsTEST>().l1Selected == true)
            {

                switch (rNUM)
                {
                    case 1:
                        Instantiate(smallUnitOBJ, lane1Pos, Quaternion.identity);
                        break;

                    case 2:
                        Instantiate(rangeUnitOBJ, lane1Pos, Quaternion.identity);
                        break;

                    case 3:
                        Instantiate(largeUnitOBJ, lane1Pos, Quaternion.identity);
                        break;

                    default:
                        print("ERROR");
                        break;
                }
            }

            if (GameObject.Find("New Player Control").GetComponentInParent<NewPllayerControlsTEST>().l2Selected == true)
            {

                switch (rNUM)
                {
                    case 1:
                        Instantiate(smallUnitOBJ, lane2Pos, Quaternion.identity);
                        break;

                    case 2:
                        Instantiate(rangeUnitOBJ, lane2Pos, Quaternion.identity);
                        break;

                    case 3:
                        Instantiate(largeUnitOBJ, lane2Pos, Quaternion.identity);
                        break;

                    default:
                        print("ERROR");
                        break;
                }

                //print("SPawn");

                
            }

            if (GameObject.Find("New Player Control").GetComponentInParent<NewPllayerControlsTEST>().l3Selected == true)
            {

                switch (rNUM)
                {
                    case 1:
                        Instantiate(smallUnitOBJ, lane3Pos, Quaternion.identity);
                        break;

                    case 2:
                        Instantiate(rangeUnitOBJ, lane3Pos, Quaternion.identity);
                        break;

                    case 3:
                        Instantiate(largeUnitOBJ, lane3Pos, Quaternion.identity);
                        break;

                    default:
                        print("ERROR");
                        break;
                }
            }

                spawnClock = 0;

        }

       


    }

     
}

