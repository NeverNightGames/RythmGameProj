using UnityEngine;
using System.Collections;

public class BeatControlTEST : MonoBehaviour {

	public float i = 0;

    public float moveBeatDia = -10;

    public float moveTime;


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


    public bool moveD1;

    public bool moveD2;

    public bool moveD3;

    public bool moveD4;


	// Use this for initialization
	void Start () 
	{
		aSource = GetComponent<AudioSource>();

		//aSource.clip = A1;

        //moveD1 = true;

       
      

	}
	
	// Update is called once per frame
	void Update () 
	{

		i++;

        moveBeatDia++;

        float M1 = -9;

        float M2 = 30;

        float M3 = 70;



        //if (moveBeatDia == M1)
        //{
        //    moveD1 = true;
        //}

        if (i == Beat1 - 10)
        {
            moveD1 = true;
        }
       

		if(i == Beat1) 
		{
			aSource.clip = A1;

			aSource.Play ();

			B1 = true;

		}
		else
		{
			//B1 = false;
		}

        if (i == Beat2 - 10)
        {
            moveD2 = true;

            moveD1 = false;

            moveD1 = false;
        }
      


		if(i ==  Beat2) 
		{
			//aSource.clip = A2;

			aSource.Play ();

			B2 = true;

            B1 = false;
		}
		else
		{
			//B2 = false;
		}

        if (i == Beat3 - 10)
        {
            moveD3 = true;

            moveD2 = false;

            moveD1 = false;
        }
      
		
		if(i ==  Beat3) 
		{
			//aSource.clip = A3;

			aSource.Play ();

			B3 = true;

            B2 = false;
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

            B3 = false;

           
           
		}

        if (moveBeatDia == 140)
        {
            moveD3 = false;

            moveD1 = true;

            moveBeatDia = -10;

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
