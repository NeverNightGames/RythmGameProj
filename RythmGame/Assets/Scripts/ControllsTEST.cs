using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControllsTEST : MonoBehaviour {

	public GameObject smallOBJ;

	public GameObject bigOBJ;
	
	public GameObject rangeOBJ;


	private GameObject Lane1OBJ;

	private GameObject Lane2OBJ;

	private GameObject Lane3OBJ;


	public bool l1Selected = true;

	public bool l2Selected = false;

	public bool l3Selected = false;


	public Image blueButton1;

	public Image blueButton2;

	public Image blueButton3;


	public Image greenButton1;
	
	public Image greenButton2;

	public Image greenButton3;



//	public AudioClip A1;
//
//	public AudioClip A2;
//
//
//	private AudioSource aSource1;
//
//	private AudioSource aSource2;
//
//	private AudioSource aSource3;


	private bool hasPlayed = false;


//	public int beatCounntA;
//
//	public int beatCounntS;
//
//	public int beatCounntD;

	public float beatCount;


	// Use this for initialization
	void Start ()
	{
		Lane1OBJ = GameObject.Find ("Lane 1");

		Lane2OBJ = GameObject.Find ("Lane 2");

		Lane3OBJ = GameObject.Find ("Lane 3");


//		aSource1 = GetComponent<AudioSource>();
//
//		aSource2 = gec
//
//		aSource3 = GetComponent<AudioSource>();



	
	
	}


	
	// Update is called once per frame
	void Update () 
	{

//		Vector2 lane1POS = new Vector2(Lane1OBJ.transform.position.x,Lane1OBJ.transform.position.y - 5);
//
//		Vector2 lane2POS = new Vector2(Lane2OBJ.transform.position.x,Lane2OBJ.transform.position.y - 5);
//
//		Vector2 lane3POS = new Vector2(Lane3OBJ.transform.position.x,Lane3OBJ.transform.position.y - 5);

		OneTwoThree ();

		ASD ();

		QWE ();

	}

	void OneTwoThree()
	{

		if(Input.GetKeyDown (KeyCode.Alpha1))
		{
			//print("1");

			l1Selected = true;
			
			l2Selected = false;
			
			l3Selected = false;

		}

		if(Input.GetKeyDown (KeyCode.Alpha2))
		{
			//print("2");

			l2Selected = true;

			l1Selected = false;
			
			l3Selected = false;
		}


		if(Input.GetKeyDown (KeyCode.Alpha3))
		{
			//print("3");

			l3Selected = true;

			l1Selected = false;
			
			l2Selected = false;
		}



	}

	void ASD()
	{
		if(Input.GetKey (KeyCode.A))
		{
			//Debug.Log("A");

			blueButton1.rectTransform.localScale = new Vector3(2.5f,1.5f,1);

			if(GameObject.Find ("Beat Control").GetComponentInParent<BeatControlTEST>().B1 == true);
			{
				Debug.Log("B1");
			}

			//blueButton1.preferredHeight = 150;

			//beatCount++;
		}
		else
		{
			blueButton1.rectTransform.localScale = new Vector3(1,1,1);
		}
		
		if(Input.GetKey (KeyCode.S))
		{
			//Debug.Log("S");

			blueButton2.rectTransform.localScale = new Vector3(2.5f,1.5f,1);

			if(GameObject.Find ("Beat Control").GetComponentInParent<BeatControlTEST>().B2 == true);
			{
				Debug.Log("B2");
			}


			//beatCount++;
		}
		else
		{
			blueButton2.rectTransform.localScale = new Vector3(1,1,1);
		}
		
		if(Input.GetKey (KeyCode.D))
		{
			//Debug.Log("D");

			blueButton3.rectTransform.localScale = new Vector3(2.5f,1.5f,1);

			//beatCount++;
		}
		else
		{
			blueButton3.rectTransform.localScale = new Vector3(1,1,1);
		}
	}

	void QWE()
	{

		Vector2 lane1POS = new Vector2(Lane1OBJ.transform.position.x,Lane1OBJ.transform.position.y - 5);
		
		Vector2 lane2POS = new Vector2(Lane2OBJ.transform.position.x,Lane2OBJ.transform.position.y - 5);
		
		Vector2 lane3POS = new Vector2(Lane3OBJ.transform.position.x,Lane3OBJ.transform.position.y - 5);


//		if(beatCount >= 3)
//		{

		 if(Input.GetKey (KeyCode.Q))
		 {
			//Debug.Log("Q");

				greenButton1.rectTransform.localScale = new Vector3(2.5f,1.5f,1);
			
				if(l1Selected == true)
				{
			     // Instantiate (smallOBJ,lane1POS,Quaternion.identity);
				}

				if(l2Selected == true)
				{
					//Instantiate (smallOBJ,lane2POS,Quaternion.identity);

				}

				if(l3Selected == true)
				{
					//Instantiate (smallOBJ,lane3POS,Quaternion.identity);

				}

				//beatCount = 0;
			
		 }
		else
		{
			greenButton1.rectTransform.localScale = new Vector3(1,1,1);
		}

		
		 if(Input.GetKey (KeyCode.W))
		 {
			//Debug.Log("W");

			greenButton2.rectTransform.localScale = new Vector3(2.5f,1.5f,1);

				if(l1Selected == true)
				{
					//Instantiate (bigOBJ,lane1POS,Quaternion.identity);
				}
				
				if(l2Selected == true)
				{
					//Instantiate (bigOBJ,lane2POS,Quaternion.identity);
					
				}
				
				if(l3Selected == true)
				{
					//Instantiate (bigOBJ,lane3POS,Quaternion.identity);
					
				}
			

				//beatCount = 0;

		 }
		else
		{
			greenButton2.rectTransform.localScale = new Vector3(1,1,1);
		}
		
		 if(Input.GetKey (KeyCode.E))
		 {

			greenButton3.rectTransform.localScale = new Vector3(2.5f,1.5f,1);

			//Debug.Log("E");

				if(l1Selected == true)
				{
					//Instantiate (rangeOBJ,lane1POS,Quaternion.identity);
				}
				
				if(l2Selected == true)
				{
					//Instantiate (rangeOBJ,lane2POS,Quaternion.identity);
					
				}
				
				if(l3Selected == true)
				{
					//Instantiate (rangeOBJ,lane3POS,Quaternion.identity);
					
				}


				//beatCount = 0;


		 }
		else
		{
			greenButton3.rectTransform.localScale = new Vector3(1,1,1);
		}



		}

	}


	

//}
