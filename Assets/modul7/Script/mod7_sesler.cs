using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mod7_sesler : MonoBehaviour
{

    public AudioSource ses;
    public AudioClip[] sesler;
    public bool playWord = false;


    // Use this for initialization
    void Start()
    {
        ses = GetComponent<AudioSource>();
        playWord = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playSound()
    {
        if (playWord)
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                ses.PlayOneShot(sesler[0], 28);
            }
            else if (Input.GetKeyDown(KeyCode.V))
            {
                ses.PlayOneShot(sesler[1], 28);
            }
            else if (Input.GetKeyDown(KeyCode.LeftBracket)) //Ğ
            {
                ses.PlayOneShot(sesler[2], 28);
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                ses.PlayOneShot(sesler[3], 28);
            }
            else if (Input.GetKeyDown(KeyCode.J))
            {
                ses.PlayOneShot(sesler[4], 28);
            }
        }
    }
}
