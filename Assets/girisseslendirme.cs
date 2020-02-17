using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girisseslendirme : MonoBehaviour {


    public AudioSource ses2;
    public AudioClip[] sesler2;


    // Use this for initialization
    void Start()
    {
        ses2 = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ses2.PlayOneShot(sesler2[0], 28);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ses2.PlayOneShot(sesler2[1], 28);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ses2.PlayOneShot(sesler2[2], 28);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            ses2.PlayOneShot(sesler2[3], 28);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            ses2.PlayOneShot(sesler2[4], 28);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            ses2.PlayOneShot(sesler2[5], 28);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            ses2.PlayOneShot(sesler2[6], 28);
        }
        //else if (Input.GetKeyDown(KeyCode.Ş))
        //{
        //    ses2.PlayOneShot(sesler2[7], 28);
        //}
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        //else if (Input.GetKeyDown(KeyCode.İ))
        //{
        //    ses2.PlayOneShot(sesler2[8], 28);
        //}
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        //else if (Input.GetKeyDown(KeyCode.Ö))
        //{
        //    ses2.PlayOneShot(sesler2[8], 28);
        //}
        //else if (Input.GetKeyDown(KeyCode.Ç))
        //{
        //    ses2.PlayOneShot(sesler2[8], 28);
        //}
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            ses2.PlayOneShot(sesler2[8], 28);
        }
        //else if (Input.GetKeyDown(KeyCode.Ü))
        //{
        //    ses2.PlayOneShot(sesler2[8], 28);
        //}
    }
}
