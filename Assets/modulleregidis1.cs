﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine.SceneManagement;

public class modulleregidis1 : MonoBehaviour {

    public void sahnedegistirme(string sahneadi)
    {
        SceneManager.LoadScene(sahneadi);
    }

}
