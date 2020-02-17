using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playonh : MonoBehaviour {

    public AudioSource ses;
    public AudioClip[] sesler;

    // Use this for initialization
    void Start () {
        ses = GetComponent<AudioSource>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ses.PlayOneShot(sesler[0], 28);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            ses.PlayOneShot(sesler[1], 28);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            ses.PlayOneShot(sesler[2], 28);
        }
        //else if (Input.GetKeyDown(KeyCode.Ç))
        //{
        //    ses.PlayOneShot(sesler[3], 28);
        //}
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ses.PlayOneShot(sesler[4], 28);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ses.PlayOneShot(sesler[5], 28);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            ses.PlayOneShot(sesler[6], 28);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            ses.PlayOneShot(sesler[7], 28);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            ses.PlayOneShot(sesler[8], 28);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            ses.PlayOneShot(sesler[9], 28);
        }
        //else if (Input.GetKeyDown(KeyCode.İ))
        //{
        //    ses.PlayOneShot(sesler[10], 28);
        //}
        else if (Input.GetKeyDown(KeyCode.J))
        {
            ses.PlayOneShot(sesler[11], 28);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            ses.PlayOneShot(sesler[12], 28);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            ses.PlayOneShot(sesler[13], 28);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            ses.PlayOneShot(sesler[14], 28);
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            ses.PlayOneShot(sesler[15], 28);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            ses.PlayOneShot(sesler[16], 28);
        }
        //else if (Input.GetKeyDown(KeyCode.Ö))
        //{
        //    ses.PlayOneShot(sesler[17], 28);
        //}
        else if (Input.GetKeyDown(KeyCode.P))
        {
            ses.PlayOneShot(sesler[18], 28);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ses.PlayOneShot(sesler[19], 28);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ses.PlayOneShot(sesler[20], 28);
        }
        //else if (Input.GetKeyDown(KeyCode.Ş))
        //{
        //    ses.PlayOneShot(sesler[21], 28);
        //}
        else if (Input.GetKeyDown(KeyCode.T))
        {
            ses.PlayOneShot(sesler[22], 28);
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            ses.PlayOneShot(sesler[23], 28);
        }
        //else if (Input.GetKeyDown(KeyCode.Ü))
        //{
        //    ses.PlayOneShot(sesler[24], 28);
        //}
        else if (Input.GetKeyDown(KeyCode.V))
        {
            ses.PlayOneShot(sesler[25], 28);
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            ses.PlayOneShot(sesler[26], 28);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            ses.PlayOneShot(sesler[27], 28);
        }
    }
}
