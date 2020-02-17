using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class af_ses : MonoBehaviour {

    public AudioSource ses;
    public AudioClip[] sesler;


    // Use this for initialization
    void Start()
    {
        ses = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ses.PlayOneShot(sesler[1], 28);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            ses.PlayOneShot(sesler[0], 28);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.Semicolon)) //Ş//
        {
            ses.PlayOneShot(sesler[2], 28);
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.Quote)) //İ//
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.Slash)) // Ö//
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.Backslash)) //Ç//
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.RightBracket))  //Ü//
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.LeftBracket))  //Ğ//
        {
            ses.PlayOneShot(sesler[2], 28);
        }
    }
}
