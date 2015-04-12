using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealthTEST : MonoBehaviour {

    public Slider playerHealthSlideOBJ;

	// Use this for initialization
	void Start () 
    {
        //playerHealthSlideOBJ.value = 0.5f;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (playerHealthSlideOBJ.value == 0)
        { 
            //print("GAME OVER");
        }

	
	}


}
