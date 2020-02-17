using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mod3_sesler : MonoBehaviour
{

    public AudioSource ses;
    public AudioClip[] sesler;
    public bool playWord = true;


    // Use this for initialization
    void Start()
    {
        ses = GetComponent<AudioSource>();
        playWord = false;
    }

    // Update is called once per frame
    public void playSound()
    {
        if (playWord)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ses.PlayOneShot(sesler[0], 4);
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                ses.PlayOneShot(sesler[1], 4);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                ses.PlayOneShot(sesler[2], 4);
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                ses.PlayOneShot(sesler[3], 4);
            }
            else if (Input.GetKeyDown(KeyCode.Quote)) //İ
            {
                ses.PlayOneShot(sesler[4], 4);
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                ses.PlayOneShot(sesler[5], 4);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                ses.PlayOneShot(sesler[6], 4);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                ses.PlayOneShot(sesler[7], 4);
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                ses.PlayOneShot(sesler[8], 4);
            }
            else if (Input.GetKeyDown(KeyCode.J))
            {
                ses.PlayOneShot(sesler[9], 4);
            }
            else if (Input.GetKeyDown(KeyCode.Semicolon)) //Ş//
            {
                ses.PlayOneShot(sesler[10], 5);
            }


        }



    }
}
