using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine.SceneManagement;

public class gecis1_9 : MonoBehaviour
{
    int fTusuBasmaSayisi = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            fTusuBasmaSayisi = fTusuBasmaSayisi + 1;
            if (fTusuBasmaSayisi == 3)
            {
                StartCoroutine(sahneDegistirici());
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            SceneManager.LoadScene(1);
        }
    }
    IEnumerator sahneDegistirici()
    {
        yield return new
            WaitForSeconds(2f);
        SceneManager.LoadScene(12);
    }
}
