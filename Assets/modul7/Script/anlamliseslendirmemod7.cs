using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anlamliseslendirmemod7 : MonoBehaviour {
    
    public AudioSource ses;
    public AudioClip[] sesler;

    // Use this for initialization
    void Start () {
        ses = GetComponent<AudioSource>();
    }
    public bool playWord = true;
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
            else if (Input.GetKeyDown(KeyCode.LeftBracket)) //ğ
            {
                ses.PlayOneShot(sesler[2], 28);
            }
            else if (Input.GetKeyDown(KeyCode.Slash)) //Ö
            {
                ses.PlayOneShot(sesler[3], 28);
            }
            else if (Input.GetKeyDown(KeyCode.Quote)) //i
            {
                ses.PlayOneShot(sesler[4], 28);
            }
            else if (Input.GetKeyDown(KeyCode.Backslash)) //Ç
            {
                ses.PlayOneShot(sesler[5], 28);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                ses.PlayOneShot(sesler[6], 28);
            }
            else if (Input.GetKeyDown(KeyCode.I))
            {
                ses.PlayOneShot(sesler[7], 28);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                ses.PlayOneShot(sesler[8], 28);
            }
            else if (Input.GetKeyDown(KeyCode.M))
            {
                ses.PlayOneShot(sesler[9], 28);
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                ses.PlayOneShot(sesler[10], 28);
            }
            else if (Input.GetKeyDown(KeyCode.J))
            {
                ses.PlayOneShot(sesler[11], 28);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                ses.PlayOneShot(sesler[12], 28);
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                ses.PlayOneShot(sesler[13], 28);
            }
            else if (Input.GetKeyDown(KeyCode.T))
            {
                ses.PlayOneShot(sesler[14], 28);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                ses.PlayOneShot(sesler[16], 28);
            }
            else if (Input.GetKeyDown(KeyCode.RightBracket)) //ü
            {
                ses.PlayOneShot(sesler[17], 28);
            }
        }
    }
}
