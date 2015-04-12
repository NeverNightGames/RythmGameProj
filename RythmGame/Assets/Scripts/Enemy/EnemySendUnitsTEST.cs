using UnityEngine;
using System.Collections;

public class EnemySendUnitsTEST : MonoBehaviour
{

    public GameObject smallUnitOBJ;

    public GameObject rangeUnitOBJ;

    public GameObject largeUnitOBJ;


    private GameObject Lane2OBJ;

    int rNUM;


    private float spawnClock;

    public float spawnTime;


    //public bool spawn;


    // Use this for initialization
    void Start()
    {
        Lane2OBJ = GameObject.Find("Lane 2");

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lanepos = new Vector2(Lane2OBJ.transform.position.x, Lane2OBJ.transform.position.y + 10);

       // rNUM = Random.Range(1, 4);

        // print(rNUM);

        spawnClock += Time.deltaTime;

        print(spawnClock);

        if (spawnClock >= spawnTime)
        {
           

            rNUM = Random.Range(1, 4);

         

            switch (rNUM)
            {
                case 1:
                    Instantiate(smallUnitOBJ, lanepos, Quaternion.identity);
                    break;

                case 2:
                    Instantiate(rangeUnitOBJ, lanepos, Quaternion.identity);
                    break;

                case 3:
                    Instantiate(largeUnitOBJ, lanepos, Quaternion.identity);
                    break;

                default:
                    print("ERROR");
                    break;
            }

            spawnClock = 0;

           
        }




        //if (rNUM == 1)
        //{
        //    Instantiate(smallUnitOBJ, lanepos, Quaternion.identity);
        //}

        //if (rNUM == 2)
        //{
        //    Instantiate(smallUnitOBJ, lanepos, Quaternion.identity);
        //}

        //if (rNUM == 3)
        //{
        //    Instantiate(smallUnitOBJ, lanepos, Quaternion.identity);
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {

            //Debug.Log(Random.Range(1, 4));

            // Instantiate(unitOBJ, lanepos, Quaternion.identity);





        }

    }
}
