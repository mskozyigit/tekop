using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine.SceneManagement;

public class sadeceharf : MonoBehaviour {


    public AudioSource ses2;
    public AudioClip[] sesler2;
    public bool playWord = true;

    // Use this for initialization
    void Start () {
        ses2 = GetComponent<AudioSource>();
        playWord = false;
    }
    public void playSound()
    {
        if (playWord)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ses2.PlayOneShot(sesler2[0], 4);
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                ses2.PlayOneShot(sesler2[1], 4);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                ses2.PlayOneShot(sesler2[2], 4);
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                ses2.PlayOneShot(sesler2[3], 4);
            }
            else if (Input.GetKeyDown(KeyCode.Quote)) //İ
            {
                ses2.PlayOneShot(sesler2[4], 4);
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                ses2.PlayOneShot(sesler2[5], 4);
            }
        }
    }
}
