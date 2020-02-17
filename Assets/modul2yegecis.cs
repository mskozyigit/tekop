using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine.SceneManagement;

public class modul2yegecis : MonoBehaviour
{
    public int level_id;

    public void sahnedegis(int sahne_id)
    {

    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            level_id++;
            PlayerPrefs.SetInt("levelid", level_id);
            SceneManager.LoadScene(13);
        }
    }
}
