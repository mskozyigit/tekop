using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anlamsizseslendirmemod6 : MonoBehaviour
{

    public AudioSource ses2;
    public AudioClip[] sesler2;

    // Use this for initialization
    void Start()
    {
        ses2 = GetComponent<AudioSource>();
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
            if (Input.GetKeyDown(KeyCode.Z))
            {
                ses2.PlayOneShot(sesler2[0], 28);
            }
            else if (Input.GetKeyDown(KeyCode.Backslash)) //ç
            {
                ses2.PlayOneShot(sesler2[1], 28);
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                ses2.PlayOneShot(sesler2[2], 28);
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                ses2.PlayOneShot(sesler2[3], 28);
            }
            else if (Input.GetKeyDown(KeyCode.Semicolon)) //ş
            {
                ses2.PlayOneShot(sesler2[4], 28);
            }
            else if (Input.GetKeyDown(KeyCode.P))
            {
                ses2.PlayOneShot(sesler2[5], 28);
            }
        }
    }

}