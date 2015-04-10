using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerBeatTEST : MonoBehaviour
{



    public Image beatButton1;

    public Image beatButton2;

    public Image beatButton3;

   // public float moveTime;

    //public GameObject[] BeatDia;


    private GameObject BeatDia1;

    private GameObject BeatDia2;

    private GameObject BeatDia3;


    private Vector3 BDStartpos1;

    private Vector3 BDStartpos2;

    private Vector3 BDStartpos3;


   // private bool done1 = false;


    //private GameObject beatOBJ;

    // Use this for initialization
    void Start()
    {
        //beatOBJ = GameObject.Find("Beat Control");

        BeatDia1 = GameObject.Find("Diamond");

        BeatDia2 = GameObject.Find("Diamond 2");

        BeatDia3 = GameObject.Find("Diamond 3");


        BDStartpos1 = BeatDia1.transform.position;

        BDStartpos2 = BeatDia2.transform.position;

        BDStartpos3 = BeatDia3.transform.position;

        //BeatDia1.SetActive(false);

        //BeatDia2.SetActive(false);

        //BeatDia3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.transform.position = B1Image.transform.position;

        // Vector3 BD1CP = new Vector3(-424,-68,0);

        //transform.position = Vector2.Lerp(this.gameObject.transform.position,beatImage.transform.position,beatOBJ.GetComponentInParent<BeatControlTEST>().i * Time.deltaTime);

       // BeatDia1.transform.position = Vector2.Lerp(BeatDia1.transform.position, beatButton1.transform.position, 50 * Time.deltaTime);

        if (GameObject.Find("Beat Control").GetComponentInParent<BeatControlTEST>().moveD1 == true)
        {
            BeatDia1.transform.position = Vector2.Lerp(BeatDia1.transform.position, beatButton1.transform.position, 10 * Time.deltaTime);

            BeatDia1.SetActive(true);
        }

        if (GameObject.Find("Beat Control").GetComponentInParent<BeatControlTEST>().moveD2 == true)
        {
            BeatDia2.transform.position = Vector2.Lerp(BeatDia2.transform.position, beatButton2.transform.position, 10 * Time.deltaTime);

            BeatDia2.SetActive(true);
        }

        if (GameObject.Find("Beat Control").GetComponentInParent<BeatControlTEST>().moveD3 == true)
        {
            BeatDia3.transform.position = Vector2.Lerp(BeatDia3.transform.position, beatButton3.transform.position, 10 * Time.deltaTime);

            BeatDia3.SetActive(true);

            //done1 = true;
        }

        if (GameObject.Find("Beat Control").GetComponentInParent<BeatControlTEST>().B4 == true)
        {

            BeatDia1.transform.position = BDStartpos1;

            BeatDia2.transform.position = BDStartpos2;

            BeatDia3.transform.position = BDStartpos3;

            //done1 = false;


          //  BeatDia1.SetActive(false);

           // BeatDia2.SetActive(false);

           // BeatDia3.SetActive(false);

        }           



    }
}
