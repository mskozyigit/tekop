using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using System.IO;



public class register : MonoBehaviour {

    public static string dataPath;
    string m_Path;

    public GameObject username;
    private string Username;
    private string form;
    private string[] Characters = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k",
                                   "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
                                   "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G",
                                   "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
                                   "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3",
                                   "4", "5", "6", "7", "8", "9", "0", "_", "-"};

    public Text mesajText;
    string mesaj;

    public void Start()
    {
        //Get the path of the Game data folder
        m_Path = Application.dataPath;

        //Output the Game data path to the console
        Debug.Log("Path : " + m_Path);
    }

    public void RegisterButton()
    {
        bool UN = false;
        //bool PW = false;
        //bool CPW = false;
        if (Username != "")
        {
            if (!System.IO.File.Exists(m_Path + @"../../UnityTest/" + Username + ".txt"))
            {
                UN = true;
            }
            else
            {
                Debug.LogWarning("Username taken");
                mesaj = "Kullanıcı adı alınmış. Lütfen başka bir kullanıcı adı belirleyin.";
                mesajText.text = mesaj;
            }
        }
        else
        {
            Debug.LogWarning("Username field empty");
            mesaj = "Kullanıcı adı kısmı boş bırakılamaz. Lütfen kullanıcı adı belirleyin.";
            mesajText.text = mesaj;
        }

        if (UN == true)
        {
            form = (Username + Environment.NewLine);
            System.IO.File.WriteAllText(m_Path + @"../../UnityTest/" + Username + ".txt", form);
            username.GetComponent<InputField>().text = "";
            print("Registration Completed");
            mesaj = "Kaydınız oluşturuldu. Giriş yap butonuna tıklayarak giriş yapabilirsiniz.";
            mesajText.text = mesaj;
            

            Directory.CreateDirectory(m_Path + @"../../Test Sonuçları/" + Username + "/");
        }
    }

   
    void Update () {
        Username = username.GetComponent<InputField>().text;
    }
}


