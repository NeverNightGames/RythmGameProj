using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerBeatTEST : MonoBehaviour {

	public Image beatImage;

	public float moveTime;

	private GameObject beatOBJ;

	// Use this for initialization
	void Start () 
	{
		beatOBJ = GameObject.Find("Beat Control");
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//this.gameObject.transform.position = B1Image.transform.position;


		transform.position = Vector2.Lerp(this.gameObject.transform.position,beatImage.transform.position,beatOBJ.GetComponentInParent<BeatControlTEST>().i * Time.deltaTime);

	
	}
}
