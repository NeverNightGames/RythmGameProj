using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BeatMove : MonoBehaviour
{

    public Image beatButton1;

    public Image beatButton2;

    public Image beatButton3;


    public Image beatShape1;

    public Image beatShape2;

    public Image beatShape3;

    public Image beatShape4;


    public float beat1speed;

    public float beat2speed;

    public float beat3speed;

    public float beat4speed;


    private Vector2 beat1StartPos;

    private Vector2 beat2StartPos;

    private Vector2 beat3StartPos;

    private Vector2 beat4StartPos;


    public bool Accept1;

    public bool Accept2;

    public bool Accept3;

    public bool Accept4;


    //public float beat4Time;


    private float waittime;

    private bool reset = false;

    public bool canMake = false;



    // Use this for initialization
    void Start()
    {
        

        Vector2 spawnPos1 = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));

        Vector2 spawnPos2 = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));

        Vector2 spawnPos3 = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));

        Vector2 spawnPos4 = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));


        beatShape1.transform.position = spawnPos1;

        beatShape2.transform.position = spawnPos2;

        beatShape3.transform.position = spawnPos3;

        beatShape4.transform.position = spawnPos4;


        beat1StartPos = beatShape1.transform.position;

        beat2StartPos = beatShape2.transform.position;

        beat3StartPos = beatShape3.transform.position;

        beat4StartPos = beatShape4.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 spawnPos = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));

     
        //beatShape1.transform.position = spawnPos;

        beatShape1.transform.position = Vector2.Lerp(beatShape1.transform.position, beatButton1.transform.position, beat1speed * Time.deltaTime);

        if (GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit1 == true)
        {
          
            canMake = false;

            beatShape2.transform.position = Vector2.Lerp(beatShape2.transform.position, beatButton2.transform.position, beat2speed * Time.deltaTime);

           // beatShape2.gameObject.SetActive(false);


        }

        if (GameObject.Find("Diamond 2").GetComponentInParent<BeatShape>().hit2 == true)
        {

            beatShape3.transform.position = Vector2.Lerp(beatShape3.transform.position, beatButton3.transform.position, beat3speed * Time.deltaTime);

           // beatShape2.gameObject.SetActive(false);

            //beatShape3.gameObject.SetActive(false);


        }

        if (GameObject.Find("Diamond 3").GetComponentInParent<BeatShape>().hit3 == true)
        {
            beatShape4.transform.position = Vector2.Lerp(beatShape4.transform.position, beatButton2.transform.position, beat4speed * Time.deltaTime);

            //beatShape3.gameObject.SetActive(false);

            //beatShape4.gameObject.SetActive(false);

        }


        if (GameObject.Find("Diamond 4").GetComponentInParent<BeatShape>().hit4 == true)
        {

           // beatShape4.gameObject.SetActive(false);

            canMake = true;


            Vector2 spawnPos1 = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));

            Vector2 spawnPos2 = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));

            Vector2 spawnPos3 = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));

            Vector2 spawnPos4 = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));


            beatShape1.transform.position = spawnPos1;

            beatShape2.transform.position = spawnPos2;

            beatShape3.transform.position = spawnPos3;

            beatShape4.transform.position = spawnPos4;



            GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit1 = false;

            GameObject.Find("Diamond 2").GetComponentInParent<BeatShape>().hit2 = false;

            GameObject.Find("Diamond 3").GetComponentInParent<BeatShape>().hit3 = false;

            GameObject.Find("Diamond 4").GetComponentInParent<BeatShape>().hit4 = false;


           // print("HIT 4");

            beatShape2.gameObject.SetActive(true);

            beatShape3.gameObject.SetActive(true);

            beatShape4.gameObject.SetActive(true);

           // reset = true;

        }


    }


}
