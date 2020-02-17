using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


[Serializable]
class PlayerData
{
    public string userName;
    
}

public class login : MonoBehaviour {

    public static string dataPath;
    string m_Path;

    public GameObject username;
    //public GameObject password;
    private string Username;
    //private string Password;
    private String[] Lines;
    private string DecryptedPass;

    public Text mesajText;
    string mesaj;

    public void Start()
    {
        //Get the path of the Game data folder
        m_Path = Application.dataPath;

        //Output the Game data path to the console
        Debug.Log("Path : " + m_Path);
    }

        public void LoginButton()
    {
        bool UN = false;
        //bool PW = false;

        if (Username != "")
        {
            if (System.IO.File.Exists(m_Path + @"../../UnityTest/" + Username + ".txt"))
            {
                UN = true;
                Lines = System.IO.File.ReadAllLines(m_Path + @"../../UnityTest/" + Username + ".txt");

                Directory.CreateDirectory(m_Path + @"../../UnityTest/active_user");
                System.IO.File.WriteAllText(m_Path + @"../../UnityTest/active_user/user.txt", Username);
            }
            else
            {
                Debug.LogWarning("Username Invalid");
                mesaj = "Kullanıcı adı yanlış. Tekrar deneyiniz!";
                mesajText.text = mesaj;
            }
        }
        else
        {
            Debug.LogWarning("Username Field Empty");
            mesaj = "Kullanıcı adı kısmı boş bırakılamaz.";
            mesajText.text = mesaj;
        }


        if (UN == true)
        {
            username.GetComponent<InputField>().text = "";
            
            
            Debug.Log("Hoşgeldin " + username);

            SceneManager.LoadScene(1);
        }
    }

[SerializeField]
void Update () {
        
        Username = username.GetComponent<InputField>().text;
        
    }
}
