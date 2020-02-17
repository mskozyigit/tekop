using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mod6_gecis : MonoBehaviour
{
    public int nextSceneId;
    int sayac = 0;
    int sayac2 = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SahneDegistirici());
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

    IEnumerator SahneDegistirici()
    {
        yield return new
            WaitForSeconds(0f);
        SceneManager.LoadScene(nextSceneId);
    }
}
