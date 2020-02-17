using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

public class GeneralController8 : MonoBehaviour {

    public static string GetCurrentUser()
    {
        var m_Path = Application.dataPath;
        if (System.IO.File.Exists(m_Path + @"../../UnityTest/active_user/user.txt"))
        {
            var username = System.IO.File.ReadAllText(m_Path + @"../../UnityTest/active_user/user.txt");
            return username;
        }
        return null;
    }


    public static void RecordUserScore(string veriler3, InputField fieldText, Text kullaniciText)
    {
        var username = GeneralController.GetCurrentUser();

        //Get the path of the Game data folder
        var m_Path = Application.dataPath;

        //Output the Game data path to the console
        Debug.Log("Path : " + m_Path);

        float offsetAngle = 0f; // Think of this like a time zone
        float hourAngle = 360f / 24f;
        float minuteAngle = 360f / (24f * 60f);
        float secondAngle = 360f / (24f * 60f * 60f);
        DateTime currentTime = System.DateTime.Now;
        float currentSunAngle = offsetAngle +
            currentTime.Hour * hourAngle +
            currentTime.Minute * minuteAngle +
            currentTime.Second * secondAngle;

        //tarih = DateTime.Today;
        var tarih = DateTime.Now.ToString("d.MM.yyyy");
        var tarih2 = DateTime.Now.ToString("hh.mm.ss");

        //username = Environment.GetEnvironmentVariable('userName');
        //CurrentUser(username);

        StreamWriter sw = new StreamWriter(m_Path + @"../../Test Sonuçları/" + username + "/" + "Modül 8 Sonuçları - " + tarih + ".txt", true);

        //sw.WriteLine("Modul 1 TEST SONUÇLARI");
        //sw.WriteLine(tarih2);

        if (fieldText.text == kullaniciText.text)
        {
            sw.WriteLine(veriler3 + " , " + "Başlama saatiniz: " + tarih2);
        }

        Debug.Log("Table successfully written to file!");

        sw.Close();
    }

    public static void SaveFile()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        file.Close();
    }

    public static void LoadFile()
    {
        int currentScore = 0;
        string currentName = "Asd";
        float currentTimePlayed = 5.0f;

        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenRead(destination);
        else
        {
            Debug.LogError("File not found");
            return;
        }

        BinaryFormatter bf = new BinaryFormatter();
        harfbirlesimi data = (harfbirlesimi)bf.Deserialize(file);
        file.Close();

        currentScore = data.score1;
        currentName = data.name1;
        currentTimePlayed = data.timePlayed;

        Debug.Log(data.name1);
        Debug.Log(data.score1);
        Debug.Log(data.timePlayed);
    }
}
