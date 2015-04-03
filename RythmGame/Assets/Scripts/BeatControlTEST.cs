using UnityEngine;
using System.Collections;

public class BeatControlTEST : MonoBehaviour {

	public float i = 0;


	private AudioSource aSource;


	public AudioClip A1;

	public AudioClip A2;

	//public AudioClip A3;

	//public AudioClip A4;


	public float Beat1;

	public float Beat2;

	public float Beat3;

	public float Beat4;

	public float Reset;


	public bool B1;

	public bool B2;

	public bool B3;

	public bool B4;


	// Use this for initialization
	void Start () 
	{
		aSource = GetComponent<AudioSource>();

		//aSource.clip = A1;



	}
	
	// Update is called once per frame
	void Update () 
	{



		i++;

		if(i ==  Beat1) 
		{
			aSource.clip = A1;

			aSource.Play ();

			B1 = true;

		}
		else
		{
			//B1 = false;
		}


		if(i ==  Beat2) 
		{
			//aSource.clip = A2;

			aSource.Play ();

			B2 = true;
		}
		else
		{
			//B2 = false;
		}


		
		if(i ==  Beat3) 
		{
			//aSource.clip = A3;

			aSource.Play ();

			B3 = true;
		}
		else
		{
			//B3 = false;
		}


		if(i == Beat4) 
		{

			aSource.clip = A2;

			aSource.Play ();

			B4 = true;
		}
		else
		{
			//B4 = false;
		}


		if(i == Reset) 
		{
			i = 0;

			B1 = false;

			B2 = false;

			B3 = false;

			B4 = false;
		}


	
	}


}
