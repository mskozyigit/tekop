using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playonh : MonoBehaviour
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
    

    public void playSound()
    {
        if (playWord)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                ses.PlayOneShot(sesler[0], 1);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                ses.PlayOneShot(sesler[1], 1);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                ses.PlayOneShot(sesler[2], 1);
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                ses.PlayOneShot(sesler[3], 2);
            }
            else if (Input.GetKeyDown(KeyCode.J))
            {
                ses.PlayOneShot(sesler[4], 1);
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                ses.PlayOneShot(sesler[5], 1);
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                ses.PlayOneShot(sesler[6], 1);
            }
            else if (Input.GetKeyDown(KeyCode.Semicolon)) //ş
            {
                ses.PlayOneShot(sesler[7], 2);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                ses.PlayOneShot(sesler[8], 1);
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                ses.PlayOneShot(sesler[9], 1);
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                ses.PlayOneShot(sesler[10], 1);
            }
            else if (Input.GetKeyDown(KeyCode.Quote)) //i
            {
                ses.PlayOneShot(sesler[11], 1);
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                ses.PlayOneShot(sesler[12], 1);
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                ses.PlayOneShot(sesler[13], 1);
            }
            else if (Input.GetKeyDown(KeyCode.V))
            {
                ses.PlayOneShot(sesler[14], 1);
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                ses.PlayOneShot(sesler[15], 1);
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                ses.PlayOneShot(sesler[16], 1);
            }
            else if (Input.GetKeyDown(KeyCode.M))
            {
                ses.PlayOneShot(sesler[17], 1);
            }
            else if (Input.GetKeyDown(KeyCode.Slash)) //ö
            {
                ses.PlayOneShot(sesler[18], 2);
            }
            else if (Input.GetKeyDown(KeyCode.LeftBracket)) //ğ
            {
                ses.PlayOneShot(sesler[19], 2);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                ses.PlayOneShot(sesler[20], 2);
            }
            else if (Input.GetKeyDown(KeyCode.RightBracket)) //ü
            {
                ses.PlayOneShot(sesler[21], 2);
            }
            else if (Input.GetKeyDown(KeyCode.P))
            {
                ses.PlayOneShot(sesler[22], 1);
            }
            else if (Input.GetKeyDown(KeyCode.O))
            {
                ses.PlayOneShot(sesler[23], 1);
            }
            else if (Input.GetKeyDown(KeyCode.I))
            {
                ses.PlayOneShot(sesler[24], 1);
            }
            else if (Input.GetKeyDown(KeyCode.U))
            {
                ses.PlayOneShot(sesler[25], 1);
            }
            else if (Input.GetKeyDown(KeyCode.Y))
            {
                ses.PlayOneShot(sesler[26], 1);
            }
            else if (Input.GetKeyDown(KeyCode.T))
            {
                ses.PlayOneShot(sesler[27], 1);
            }
            else if (Input.GetKeyDown(KeyCode.Backslash)) //ç
            {
                ses.PlayOneShot(sesler[28], 1);
            }
        }
    }
}
