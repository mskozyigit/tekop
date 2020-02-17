using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seslendirmemod4 : MonoBehaviour {

    public AudioSource ses2;
    public AudioClip[] sesler2;
    public bool playWord = true;

    // Use this for initialization
    void Start () {
        ses2 = GetComponent<AudioSource>();
        playWord = false;
    }
    
    // Update is called once per frame
    public void playSound()
    {
        if (playWord)
        {
            //modulde ses çıkarma kısmında hangi harfler varsa hepsi eklenecek
            if (Input.GetKeyDown(KeyCode.Y))
            {
                ses2.PlayOneShot(sesler2[0], 4);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                ses2.PlayOneShot(sesler2[1], 4);
            }
            else if (Input.GetKeyDown(KeyCode.M))
            {
                ses2.PlayOneShot(sesler2[2], 4);
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                ses2.PlayOneShot(sesler2[3], 4);
            }
            else if (Input.GetKeyDown(KeyCode.U))
            {
                ses2.PlayOneShot(sesler2[4], 4);
            }
            else if (Input.GetKeyDown(KeyCode.T))
            {
                ses2.PlayOneShot(sesler2[5], 4);
            }
            else if (Input.GetKeyDown(KeyCode.O))
            {
                ses2.PlayOneShot(sesler2[6], 4);
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                ses2.PlayOneShot(sesler2[7], 4);
            }
            else if (Input.GetKeyDown(KeyCode.RightBracket)) //Ü
            {
                ses2.PlayOneShot(sesler2[8], 5);
            }
            else if (Input.GetKeyDown(KeyCode.Y))
            {
                ses2.PlayOneShot(sesler2[9], 4);
            }
            else if (Input.GetKeyDown(KeyCode.Quote)) //İ//
            {
                ses2.PlayOneShot(sesler2[10], 4);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                ses2.PlayOneShot(sesler2[11], 4);
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                ses2.PlayOneShot(sesler2[12], 4);
            }
            else if (Input.GetKeyDown(KeyCode.Slash)) //Ö
            {
                ses2.PlayOneShot(sesler2[13], 5);
            }
        }
    }
}
