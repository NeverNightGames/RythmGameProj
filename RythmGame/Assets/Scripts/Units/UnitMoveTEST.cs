using UnityEngine;
using System.Collections;

public class UnitMoveTEST : MonoBehaviour {

	public float unitSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.gameObject.transform.Translate (0,unitSpeed,0);
	
	}

    //void OnCollisionEnter2D(Collision2D col)
    //{
        
    //}


	void OnTriggerEnter2D(Collider2D col)
	{
		Destroy (this.gameObject);
	}
}
