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

    //public float beat4Time;

    private float waittime;

    private bool reset = false;

    public bool canMake = false;


    // Use this for initialization
    void Start()
    {
        beat1StartPos = beatShape1.transform.position;

        beat2StartPos = beatShape2.transform.position;

        beat3StartPos = beatShape3.transform.position;

        beat4StartPos = beatShape4.transform.position;


    }

    // Update is called once per frame
    void Update()
    {

        //if (reset == false)
        //{

        //canMake = false;

        beatShape1.transform.position = Vector2.Lerp(beatShape1.transform.position, beatButton1.transform.position, beat1speed * Time.deltaTime);

        if (GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit1 == true)
        {
            //GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit1 = false;
            canMake = false;

            beatShape2.transform.position = Vector2.Lerp(beatShape2.transform.position, beatButton2.transform.position, beat2speed * Time.deltaTime);

           // GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio1 = true;

           // GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit1 = false;
        }

        if (GameObject.Find("Diamond 2").GetComponentInParent<BeatShape>().hit2 == true)
        {
           // GameObject.Find("Diamond 2").GetComponentInParent<BeatShape>().hit2 = false;

            beatShape3.transform.position = Vector2.Lerp(beatShape3.transform.position, beatButton3.transform.position, beat3speed * Time.deltaTime);

             //GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit1 = false;

            //GameObject.Find("Diamond 2").GetComponentInParent<BeatShape>().hit2 = false;

        }

        if (GameObject.Find("Diamond 3").GetComponentInParent<BeatShape>().hit3 == true)
        {
            //waittime += Time.deltaTime;

            beatShape4.transform.position = Vector2.Lerp(beatShape4.transform.position, beatButton2.transform.position, beat4speed * Time.deltaTime);

            // GameObject.Find("Diamond 2").GetComponentInParent<BeatShape>().hit2 = false;


        }


        if (GameObject.Find("Diamond 4").GetComponentInParent<BeatShape>().hit4 == true)
        {

            //GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit1 = false;

            //GameObject.Find("Diamond 2").GetComponentInParent<BeatShape>().hit2 = false;

            //GameObject.Find("Diamond 3").GetComponentInParent<BeatShape>().hit3 = false;

            //GameObject.Find("Diamond 4").GetComponentInParent<BeatShape>().hit4 = false;

            canMake = true;

            beatShape1.transform.position = beat1StartPos;

            beatShape2.transform.position = beat2StartPos;

            beatShape3.transform.position = beat3StartPos;

            beatShape4.transform.position = beat4StartPos;


            GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit1 = false;

            GameObject.Find("Diamond 2").GetComponentInParent<BeatShape>().hit2 = false;

            GameObject.Find("Diamond 3").GetComponentInParent<BeatShape>().hit3 = false;

            GameObject.Find("Diamond 4").GetComponentInParent<BeatShape>().hit4 = false;

          

            print("HIT 4");

           // reset = true;

        }


        //if (reset == true)
        //{
        //    GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit1 = false;

        //    GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit2 = false;

        //    GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit3 = false;

        //    GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit4 = false;



        //beatShape1.transform.position = beat1StartPos;

        //beatShape2.transform.position = beat2StartPos;

        //beatShape3.transform.position = beat3StartPos;

        //beatShape4.transform.position = beat4StartPos;

        //    reset = false;
        //}
        // }


    }


}
