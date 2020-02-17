using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clickgelistirenler : MonoBehaviour {

    public Button anasayfa;

    public void sahnedegistirme(string sahneadi)
    {
        if (anasayfa)
        {
            SceneManager.LoadScene(sahneadi);
        }
    }
}
