using UnityEngine;
using System.Collections;

public class PlayerDeathTrigTEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy Range")
        {
            GameObject.Find("New Player Control").GetComponentInParent<PlayerHealthTEST>().playerHealthSlideOBJ.value -= 1;
        }

        if (col.gameObject.tag == "Enemy Large")
        {
            GameObject.Find("New Player Control").GetComponentInParent<PlayerHealthTEST>().playerHealthSlideOBJ.value -= 1;
        }

        if (col.gameObject.tag == "Enemy Small")
        {
            GameObject.Find("New Player Control").GetComponentInParent<PlayerHealthTEST>().playerHealthSlideOBJ.value -= 1;
        }


        Destroy(col.gameObject);

    }
}
