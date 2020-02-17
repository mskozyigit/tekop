using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class tabtusu : MonoBehaviour {


    public AudioSource sesler;
    public AudioClip[] modulSesleri;
    int sayac = 0;

    public List<Selectable> selectables = new List<Selectable>();

    void Start()
    {
        sesler = GetComponent<AudioSource>();
    }

    public void sahnedegistirme(string sahneadi)
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(sahneadi);
        }
    }

    private void Update()
    {
        //KeyCode.Tab.interactiable = false;
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Navigate backward when holding shift, else navigate forward.
            this.HandleHotkeySelect(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift), true);
            sayac++;

            if (sayac == 1)
            {
                sesler.PlayOneShot(modulSesleri[0], 8);
            }
            else if (sayac == 2)
            {
                sesler.PlayOneShot(modulSesleri[1], 8);
            }
            else if (sayac == 3)
            {
                sesler.PlayOneShot(modulSesleri[2], 8);
            }
            else if (sayac == 4)
            {
                sesler.PlayOneShot(modulSesleri[3], 8);
            }
            else if (sayac == 5)
            {
                sesler.PlayOneShot(modulSesleri[4], 8);
            }
            else if (sayac == 6)
            {
                sesler.PlayOneShot(modulSesleri[5], 8);
            }
            else if (sayac == 7)
            {
                sesler.PlayOneShot(modulSesleri[6], 8);
            }
            else if (sayac == 8)
            {
                sesler.PlayOneShot(modulSesleri[7], 8);
            }
            else if (sayac == 9)
            {
                sesler.PlayOneShot(modulSesleri[8], 8);
                sayac = 0;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return))
        {
            EventSystem.current.SetSelectedGameObject(null, null);
            sayac = 0;
        }

        
    }

    private void HandleHotkeySelect(bool isNavigateBackward, bool isWrapAround)
    {
        GameObject selectedObject = EventSystem.current.currentSelectedGameObject;
        if (selectedObject != null && selectedObject.activeInHierarchy) // Ensure a selection exists and is not an inactive object.
        {
            Selectable currentSelection = selectedObject.GetComponent<Selectable>();
            if (currentSelection != null)
            {
                Selectable nextSelection = this.FindNextSelectable(
                    selectables.IndexOf(currentSelection), isNavigateBackward, isWrapAround);
                if (nextSelection != null)
                {
                    nextSelection.Select();
                }
            }
            else
            {
                this.SelectFirstSelectable();
            }
        }
        else
        {
            this.SelectFirstSelectable();
        }
    }

    private void SelectFirstSelectable()
    {
        if (selectables != null && selectables.Count > 0)
        {
            Selectable firstSelectable = selectables[0];
            firstSelectable.Select();
        }
    }

    /// <summary>
    /// Looks at ordered selectable list to find the selectable we are trying to navigate to and returns it.
    /// </summary>
    private Selectable FindNextSelectable(int currentSelectableIndex, bool isNavigateBackward, bool isWrapAround)
    {
        Selectable nextSelection = null;

        int totalSelectables = selectables.Count;
        if (totalSelectables > 1)
        {
            if (isNavigateBackward)
            {
                if (currentSelectableIndex == 0)
                {
                    nextSelection = (isWrapAround) ? selectables[totalSelectables - 1] : null;
                }
                else
                {
                    nextSelection = selectables[currentSelectableIndex - 1];
                }
            }
            else // Navigate forward.
            {
                if (currentSelectableIndex == (totalSelectables - 1))
                {
                    nextSelection = (isWrapAround) ? selectables[0] : null;
                }
                else
                {
                    nextSelection = selectables[currentSelectableIndex + 1];
                }
            }
        }

        return nextSelection;
    }
}
