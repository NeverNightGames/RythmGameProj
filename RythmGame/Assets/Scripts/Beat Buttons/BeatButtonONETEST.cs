using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BeatButtonONETEST : MonoBehaviour {

	public GameObject BeatDiamond1;

	public GameObject BeatDiamond2;

	public GameObject BeatDiamond3;

    

	// Use this for initialization
	void Start () 
	{
		BeatDiamond2.GetComponentInParent<PlayerBeatTEST>().enabled = false;

		BeatDiamond3.GetComponentInParent<PlayerBeatTEST>().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.name == BeatDiamond1.name)
		{
			//print("Diamond 1");

			BeatDiamond2.GetComponentInParent<PlayerBeatTEST>().enabled = true;


		}

		if(col.gameObject.name == BeatDiamond2.name)
		{
			//print("Diamond 2");

			BeatDiamond3.GetComponentInParent<PlayerBeatTEST>().enabled = true;
		}

		if(col.gameObject.name == BeatDiamond3.name)
		{
			//print("Diamond 3");
		}

	}
}
