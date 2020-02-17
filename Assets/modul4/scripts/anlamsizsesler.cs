using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

public class anlamsizsesler : MonoBehaviour {


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

            if (Input.GetKeyDown(KeyCode.O))
            {
                ses2.PlayOneShot(sesler2[0], 4);
            }
            else if (Input.GetKeyDown(KeyCode.M))
            {
                ses2.PlayOneShot(sesler2[1], 4);
            }
            else if (Input.GetKeyDown(KeyCode.U))
            {
                ses2.PlayOneShot(sesler2[2], 4);
            }
            else if (Input.GetKeyDown(KeyCode.T))
            {
                ses2.PlayOneShot(sesler2[3], 4);
            }
            else if (Input.GetKeyDown(KeyCode.RightBracket))
            {
                ses2.PlayOneShot(sesler2[4], 5);
            }
            else if (Input.GetKeyDown(KeyCode.Y))
            {
                ses2.PlayOneShot(sesler2[5], 4);
            }
        }
    }
}
