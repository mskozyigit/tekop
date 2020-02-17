using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tabnasil : MonoBehaviour {
    public Button gelistirenler;
    public Button nasilkullanilir;

    public void sahnedegistirme(string sahneadi)
    {
        if (gelistirenler)
        {
            SceneManager.LoadScene(sahneadi);
        }

        if (nasilkullanilir)
        {
            SceneManager.LoadScene(sahneadi);
        }
    }


}
