﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mod5_harfseslendirmesianlamli : MonoBehaviour {


    public AudioSource ses2;
    public AudioClip[] sesler2;

    // Use this for initialization
    void Start () {
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
            else if (Input.GetKeyDown(KeyCode.A))
            {
                ses2.PlayOneShot(sesler2[6], 28);
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                ses2.PlayOneShot(sesler2[7], 28);
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                ses2.PlayOneShot(sesler2[8], 28);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                ses2.PlayOneShot(sesler2[9], 28);
            }
            else if (Input.GetKeyDown(KeyCode.Quote)) //i
            {
                ses2.PlayOneShot(sesler2[10], 28);
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                ses2.PlayOneShot(sesler2[11], 28);
            }
            else if (Input.GetKeyDown(KeyCode.M))
            {
                ses2.PlayOneShot(sesler2[12], 28);
            }
            else if (Input.GetKeyDown(KeyCode.U))
            {
                ses2.PlayOneShot(sesler2[13], 28);
            }
            else if (Input.GetKeyDown(KeyCode.Y))
            {
                ses2.PlayOneShot(sesler2[14], 28);
            }
        }
    }

