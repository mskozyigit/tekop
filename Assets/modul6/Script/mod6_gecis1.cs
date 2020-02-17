using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mod6_gecis1 : MonoBehaviour
{
    public int nextSceneId;
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

    }

    IEnumerator SahneDegistirici()
    {
        yield return new
            WaitForSeconds(0f);
        SceneManager.LoadScene(nextSceneId);
    }
}
