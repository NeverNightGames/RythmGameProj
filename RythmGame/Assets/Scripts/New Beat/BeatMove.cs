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


    public float beat1speed;

    public float beat2speed;

    public float beat3speed;


    //public float beat4Time;

    private float waittime;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        beatShape1.transform.position = Vector2.Lerp(beatShape1.transform.position, beatButton1.transform.position, beat1speed * Time.deltaTime);

        if (GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit1 == true)
        {
            //GameObject.Find("Diamond").GetComponentInParent<BeatShape>().hit1 = false;

            beatShape2.transform.position = Vector2.Lerp(beatShape2.transform.position, beatButton2.transform.position, beat2speed * Time.deltaTime);

            //GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio1 = true;
        }

        if (GameObject.Find("Diamond 2").GetComponentInParent<BeatShape>().hit2 == true)
        {
            //GameObject.Find("Diamond 2").GetComponentInParent<BeatShape>().hit2 = false;

            beatShape3.transform.position = Vector2.Lerp(beatShape3.transform.position, beatButton3.transform.position, beat3speed * Time.deltaTime);

            //GameObject.Find("Diamond 2").GetComponentInParent<BeatShape>().hit2 = false;

        }

        if (GameObject.Find("Diamond 3").GetComponentInParent<BeatShape>().hit3 == true)
        {
            waittime += Time.deltaTime; 

            if (waittime >= GameObject.Find("New Beat").GetComponentInParent<NewMusic>().audio4Time)
            {

                GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio4 = true;

                GameObject.Find("Diamond 3").GetComponentInParent<BeatShape>().hit3 = false;
            }

            // GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio4 = false;

            print("HIT 4");

        }


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //if (col.gameObject.name == "BC 1")
        //{
        //    print("HIT 1");
        //}

        //if (col.gameObject.name == "BC 2")
        //{
        //    print("HIT 2");
        //}

        //if (col.gameObject.name == "BC 3")
        //{
        //    print("HIT 3");
        //}
    }
}
