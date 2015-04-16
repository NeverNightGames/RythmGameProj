using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewPllayerControlsTEST : MonoBehaviour
{

    public GameObject smallOBJ;

    public GameObject bigOBJ;

    public GameObject rangeOBJ;


    private GameObject Lane1OBJ;

    private GameObject Lane1Highlight;

    private GameObject Lane2OBJ;

    private GameObject Lane2Highlight;

    private GameObject Lane3OBJ;

    private GameObject Lane3Highlight;


    private GameObject blueButton1;

    private GameObject blueButton2;

    private GameObject blueButton3;


    private GameObject greenButton1;

    private GameObject greenButton2;

    private GameObject greenButton3;


    public bool l1Selected = false;

    public bool l2Selected = true;

    public bool l3Selected = false;


    public bool isCreated = false;

    // Use this for initialization
    void Start()
    {
        Lane1OBJ = GameObject.Find("Lane 1");

        Lane2OBJ = GameObject.Find("Lane 2");

        Lane3OBJ = GameObject.Find("Lane 3");


        Lane1Highlight = GameObject.Find("Lane 1 Highlight");

        Lane1Highlight.SetActive(false);

        Lane2Highlight = GameObject.Find("Lane 2 Highlight");

        // Lane2Highlight.SetActive(false);

        Lane3Highlight = GameObject.Find("Lane 3 Highlight");

        Lane3Highlight.SetActive(false);


        blueButton1 = GameObject.Find("BC 1");

        blueButton2 = GameObject.Find("BC 2");

        blueButton3 = GameObject.Find("BC 3");


        greenButton1 = GameObject.Find("BG 1");

        greenButton2 = GameObject.Find("BG 2");

        greenButton3 = GameObject.Find("BG 3");

    }

    // Update is called once per frame
    void Update()
    {


        OneTwoThree();

        QWE();

        ASD();

    }

    void OneTwoThree()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //print("1");

            l1Selected = true;

            Lane1Highlight.SetActive(true);

            l2Selected = false;

            Lane2Highlight.SetActive(false);

            l3Selected = false;

            Lane3Highlight.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //print("2");

            l2Selected = true;

            Lane2Highlight.SetActive(true);

            l1Selected = false;

            Lane1Highlight.SetActive(false);

            l3Selected = false;

            Lane3Highlight.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //print("3");

            l3Selected = true;

            Lane3Highlight.SetActive(true);

            l1Selected = false;

            Lane1Highlight.SetActive(false);

            l2Selected = false;

            Lane2Highlight.SetActive(false);
        }



    }

    void QWE()
    {
        Vector2 lane1POS = new Vector2(Lane1OBJ.transform.position.x, Lane1OBJ.transform.position.y - 10);

        Vector2 lane2POS = new Vector2(Lane2OBJ.transform.position.x, Lane2OBJ.transform.position.y - 10);

        Vector2 lane3POS = new Vector2(Lane3OBJ.transform.position.x, Lane3OBJ.transform.position.y - 10);


        if (Input.GetKey(KeyCode.Q))
        {
            //print("Q");

            greenButton1.GetComponent<Image>().rectTransform.localScale = new Vector2(2.5f, 2.5f);

            if (GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio4 == true)
            {
                if (!isCreated)
                {
                    if (l1Selected == true)
                    {
                        Instantiate(smallOBJ, lane1POS, Quaternion.identity);
                    }

                    if (l2Selected == true)
                    {
                        Instantiate(smallOBJ, lane2POS, Quaternion.identity);

                    }

                    if (l3Selected == true)
                    {
                        Instantiate(smallOBJ, lane3POS, Quaternion.identity);
                    }

                    isCreated = true;
                }
            }


        }
        else
        {
            greenButton1.GetComponent<Image>().rectTransform.localScale = new Vector2(1, 1);
        }


        if (Input.GetKey(KeyCode.W))
        {
            greenButton2.GetComponent<Image>().rectTransform.localScale = new Vector2(2.5f, 2.5f);

            if (GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio4 == true)
            {
                if (!isCreated)
                {

                    if (l1Selected == true)
                    {
                        Instantiate(bigOBJ, lane1POS, Quaternion.identity);
                    }

                    if (l2Selected == true)
                    {
                        Instantiate(bigOBJ, lane2POS, Quaternion.identity);

                    }

                    if (l3Selected == true)
                    {
                        Instantiate(bigOBJ, lane3POS, Quaternion.identity);

                    }

                    isCreated = true;
                }

                //isCreated = true;
            }

            //print("W");
        }
        else
        {
            greenButton2.GetComponent<Image>().rectTransform.localScale = new Vector2(1, 1);
        }



        if (Input.GetKey(KeyCode.E))
        {
            greenButton3.GetComponent<Image>().rectTransform.localScale = new Vector2(2.5f, 2.5f);

            if (GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio4 == true)
            {
                if (!isCreated)
                {

                    if (l1Selected == true)
                    {
                        Instantiate(rangeOBJ, lane1POS, Quaternion.identity);
                    }

                    if (l2Selected == true)
                    {
                        Instantiate(rangeOBJ, lane2POS, Quaternion.identity);

                    }

                    if (l3Selected == true)
                    {
                        Instantiate(rangeOBJ, lane3POS, Quaternion.identity);

                    }

                    isCreated = true;
                }

                // isCreated = true;


            }

            //print("E");
        }
        else
        {
            greenButton3.GetComponent<Image>().rectTransform.localScale = new Vector2(1, 1);
        }


    }


    void ASD()
    {

        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("A");

            blueButton1.GetComponent<Image>().rectTransform.localScale = new Vector2(2.5f, 2.5f);

            print("A");

        }
        else
        {
            blueButton1.GetComponent<Image>().rectTransform.localScale = new Vector2(1, 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("A");

            blueButton2.GetComponent<Image>().rectTransform.localScale = new Vector2(2.5f, 2.5f);

            print("S");

        }
        else
        {
            blueButton2.GetComponent<Image>().rectTransform.localScale = new Vector2(1, 1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("A");

            blueButton3.GetComponent<Image>().rectTransform.localScale = new Vector2(2.5f, 2.5f);

            print("D");

        }
        else
        {
            blueButton3.GetComponent<Image>().rectTransform.localScale = new Vector2(1, 1);
        }




    }

}

