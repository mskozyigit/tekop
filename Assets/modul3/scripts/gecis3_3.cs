﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine.SceneManagement;

public class gecis3_3 : MonoBehaviour
{
    int fTusuBasmaSayisi = 0;
    public AudioSource ses2;
    public AudioClip[] sesler2;
    int sayac = 0;
    int sayac2 = 0;
    // Use this for initialization
    void Start()
    {
        ses2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Quote))
        {
            fTusuBasmaSayisi = fTusuBasmaSayisi + 1;
            if (fTusuBasmaSayisi == 3)
            {
                StartCoroutine(sahneDegistirici());
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sayac2 = sayac2 + 1;
            if (sayac2 == 3)
            {
                Application.Quit();
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            sayac = sayac + 1;
            if (sayac == 3)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    IEnumerator sahneDegistirici()
    {
        yield return new
            WaitForSeconds(2f);
        SceneManager.LoadScene(42);
    }
}
