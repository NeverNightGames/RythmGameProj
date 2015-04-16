using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BeatShape : MonoBehaviour {

    public bool hit1 = false;

    public bool hit2 = false;

    public bool hit3 = false;


    private GameObject shape1OBJ;

    private GameObject shape2OBJ;

    private GameObject shape3OBJ;


    private Vector2 shape1StartPos;

    private Vector2 shape2StartPos;

    private Vector2 shape3StartPos;


	// Use this for initialization
	void Start () 
    {
       // this.gameObject.SetActive(false);

        shape1OBJ = GameObject.Find("Diamond");

        shape2OBJ = GameObject.Find("Diamond 2");

        shape3OBJ = GameObject.Find("Diamond 3");


        shape1StartPos = shape1OBJ.transform.position;

        shape2StartPos = shape2OBJ.transform.position;

        shape3StartPos = shape3OBJ.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio4 == true)
        {
            //shape1OBJ.transform.position = shape1StartPos;

            //shape2OBJ.transform.position = shape2StartPos;

            //shape3OBJ.transform.position = shape3StartPos;
        }
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (this.gameObject.name == "Diamond")
        {
            if (col.gameObject.name == "BC 1")
            {
                print("HIT 1");

                hit1 = true;

                GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio1 = true;
            }
        }

        if (this.gameObject.name == "Diamond 2")
        {
            if (col.gameObject.name == "BC 2")
            {
                print("HIT 2");

                hit2 = true;

                GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio2 = true;
            }
        }

        if (this.gameObject.name == "Diamond 3")
        {
            if (col.gameObject.name == "BC 3")
            {
                print("HIT 3");

                hit3 = true;

                GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio3 = true;
            }
        }

         // GameObject.Find("New Beat").GetComponentInParent<NewMusic>().playAudio3 = false;


    }

}
