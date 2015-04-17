using UnityEngine;
using System.Collections;

public class NewMusic : MonoBehaviour
{

    public AudioClip A1;

    public AudioClip A2;

    private AudioSource aSource;


    public bool playAudio1 = false;

    public bool playAudio2 = false;

    public bool playAudio3 = false;

    public bool playAudio4 = false;


    public float audio4Time;

    private float audioTimer;


    bool reset = false;

    public float resetime;

    float resetimer;


    // Use this for initialization
    void Start()
    {
        aSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

       // audioTimer += Time.deltaTime;

        


        if (playAudio1 == true)
        {
            aSource.clip = A1;

            aSource.Play();

            playAudio1 = false;

        }

        if (playAudio2 == true)
        {
            aSource.clip = A1;

            aSource.Play();

            playAudio2 = false;
        }

        if (playAudio3 == true)
        {
            aSource.clip = A1;

            aSource.Play();

            playAudio3 = false;

        }

        if (playAudio4 == true)
        {
            aSource.clip = A2;

            aSource.Play();

            playAudio4 = false;
  
        }



    }

    
       
}
