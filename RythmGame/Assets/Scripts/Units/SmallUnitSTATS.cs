using UnityEngine;
using System.Collections;

public class SmallUnitSTATS : MonoBehaviour
{

    public int smallAttack;

    public int smallDefence;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player Large")
        {
            // print("HIT");

            Destroy(this.gameObject);

            //Destroy(col.gameObject);

        }

        if (col.gameObject.tag == "Player Small")
        {
            // print("HIT");

            Destroy(this.gameObject);

            Destroy(col.gameObject);

        }

        if (col.gameObject.tag == "Player Range")
        {
            //print("HIT");

            Destroy(col.gameObject);

            //Destroy(this.gameObject);

        }
    }
}
