using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anlamsizseslendirme : MonoBehaviour
{

    public AudioSource ses2;
    public AudioClip[] sesler2;
    public bool playWord = false;

    // Use this for initialization
    void Start()
    {
        ses2 = GetComponent<AudioSource>();
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

            if (Input.GetKeyDown(KeyCode.Slash)) //Ö
            {
                ses2.PlayOneShot(sesler2[0], 28);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                ses2.PlayOneShot(sesler2[1], 28);
            }
            else if (Input.GetKeyDown(KeyCode.I))
            {
                ses2.PlayOneShot(sesler2[2], 28);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                ses2.PlayOneShot(sesler2[3], 28);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                ses2.PlayOneShot(sesler2[4], 28);
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                ses2.PlayOneShot(sesler2[5], 28);
            }
        }
    }
}