using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine.EventSystems;

public class cursor : MonoBehaviour {
    public InputField field;

    // Activate the main input field when the scene starts.
    void Start()
    {
        field.ActivateInputField();
    }

	// Update is called once per frame
	void Update()
    {
       
    }

}
