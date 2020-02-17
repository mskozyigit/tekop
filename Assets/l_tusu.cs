using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine.SceneManagement;

public class l_tusu : MonoBehaviour
{
    public AudioSource ses;
    public AudioClip[] sesler;
    int lTusuBasmaSayisi = 0;
    public int nextSceneId;
    int sayac = 0;
    int sayac2 = 0;
    public AudioClip moduleIntroduction = null;
    private bool moduleIntroductionPlaying = false;
    // Use this for initialization
    void Start()
    {
        ses = GetComponent<AudioSource>();
        if (this.moduleIntroduction != null)
        {
            moduleIntroductionPlaying = true;
            StartCoroutine(
                GeneralController.playSoundWithCallback(
                    this.ses,
                    this.moduleIntroduction,
                    () => { this.moduleIntroductionPlaying = false; }
               )
            );
        }
    }

    // Update is called once per frame
    void Update()
    {
       

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
        if (moduleIntroductionPlaying == false)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                ses.PlayOneShot(sesler[0], 4);
                lTusuBasmaSayisi = lTusuBasmaSayisi + 1;
                if (lTusuBasmaSayisi == 3)
                {
                    StartCoroutine(SahneDegistirici());
                    ses.PlayOneShot(sesler[2], 8);
                }
            }
            else if ((Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.J)) ||
                (Input.GetKeyDown(KeyCode.Semicolon)) || (Input.GetKeyDown(KeyCode.R)) || (Input.GetKeyDown(KeyCode.G)) || (Input.GetKeyDown(KeyCode.H)) ||
                (Input.GetKeyDown(KeyCode.Quote)) || (Input.GetKeyDown(KeyCode.Z)) || (Input.GetKeyDown(KeyCode.C)) || (Input.GetKeyDown(KeyCode.V)) ||
                (Input.GetKeyDown(KeyCode.B)) || (Input.GetKeyDown(KeyCode.N)) || (Input.GetKeyDown(KeyCode.M)) || (Input.GetKeyDown(KeyCode.Slash)) ||
                (Input.GetKeyDown(KeyCode.Backslash)) || (Input.GetKeyDown(KeyCode.E)) || (Input.GetKeyDown(KeyCode.T)) || (Input.GetKeyDown(KeyCode.Y)) ||
                (Input.GetKeyDown(KeyCode.U)) || (Input.GetKeyDown(KeyCode.I)) || (Input.GetKeyDown(KeyCode.O)) || (Input.GetKeyDown(KeyCode.P)) ||
                (Input.GetKeyDown(KeyCode.RightBracket)) || (Input.GetKeyDown(KeyCode.LeftBracket)) || (Input.GetKeyDown(KeyCode.F)) ||
                (Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.Q)) || (Input.GetKeyDown(KeyCode.X)) ||
                (Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.K)))
            {
                ses.PlayOneShot(sesler[1], 3);
            }
        }
    }
    IEnumerator SahneDegistirici()
    {
        yield return new
            WaitForSeconds(2f);
        SceneManager.LoadScene(nextSceneId);
    }
}
