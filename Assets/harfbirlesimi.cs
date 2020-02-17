using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class harfbirlesimi : MonoBehaviour
{

    public int score1;
    public string name1;
    public float timePlayed;
    int sayac = 0;
    int sayac2 = 0;
    public harfbirlesimi(int scoreInt, string nameStr, float timePlayedF)
    {
        score1 = scoreInt;
        name1 = nameStr;
        timePlayed = timePlayedF;
    }

    public static float fixedDeltaTime;
    public AudioSource ses;
    public AudioClip[] sesler;
    public AudioClip[] yanlisSesdit;
    public List<AudioClip> kullanicibildiriciSes = new List<AudioClip>();

    private float time1 = 0.0f;
    private float time2 = 0.0f;
    private float waitTime = 1.5f;
    private bool addTime = true;
    bool sesCaldi = true;

    //Harf listesi oluştur
    List<string> harfler = new List<string>();
    // Use this for initialization
    public InputField field;
    public Text kullaniciGirisi;
    public int nextSceneId;
    //fonksiyonu çağıracagın sayıyı oluştur
    public int secilenSayi = 0;
    List<string> kullaniciSesHarfleri = new List<string>();
    public bool isFinished;

    int score = 0;
    public Text scoreText;
    public Text timerText;
    public Text countupText;
    float totalTime = 0f;

    public Text timer;
    private bool timerfinish = false;

    private string veriler;

    int currentScore = 0;
    string currentName = "Asd";
    float currentTimePlayed = 5.0f;


    void Start()
    {
        

        kullaniciSesHarfleri.Add("a");
        kullaniciSesHarfleri.Add("s");
        kullaniciSesHarfleri.Add("d");
        kullaniciSesHarfleri.Add("f");
        kullaniciSesHarfleri.Add("j");
        kullaniciSesHarfleri.Add("k");
        kullaniciSesHarfleri.Add("l");
        kullaniciSesHarfleri.Add("ş");


        //Moduldeki harfleri ekle
        harfler.Add("a");
        harfler.Add("l");
        harfler.Add("f");
        harfler.Add("j");
        harfler.Add("s");
        harfler.Add("k");
        harfler.Add("ş");
        harfler.Add("d");
        harfler.Add("jk");
        harfler.Add("kl");
        harfler.Add("lş");
        harfler.Add("şf");
        harfler.Add("fd");
        harfler.Add("ds");
        harfler.Add("sa");
        harfler.Add("jkl");
        harfler.Add("kjd");
        harfler.Add("lşa");
        harfler.Add("fsd");
        harfler.Add("sjd");
        harfler.Add("djk");
        harfler.Add("lks");
        harfler.Add("jklş");
        harfler.Add("şlkj");
        harfler.Add("fdas");
        harfler.Add("asdf");
        harfler.Add("kşal");


        ses = GetComponent<AudioSource>();

        PlayerPrefs.SetInt("Score", 0);      
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();

        SaveFile();
        LoadFile();


    }

   

    public void SaveFile()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        harfbirlesimi data = new harfbirlesimi(currentScore, currentName, currentTimePlayed);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
    }

    public void LoadFile()
    {
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


    IEnumerator seslendirme(string text)
    {
        for (int it = 0; it < text.Length; it++)
        {
            string harf = text[it].ToString().ToLower();
            int index = kullaniciSesHarfleri.IndexOf(harf);
            ses.clip = kullanicibildiriciSes[index];
            ses.PlayOneShot(kullanicibildiriciSes[index], 29);

            sesCaldi = false;
            yield return new WaitForSeconds(ses.clip.length + 0.8f);
        }
    }

    //Harfi test eden fonksiyon
    public bool HarfTest()
    {
        for (int ii = 0; ii <= field.text.Length - 1; ii++)
        {
            if (field.text[ii] != kullaniciGirisi.text[ii])
            {
                score = score + 1;
                scoreText.text = score.ToString();
                
               //Debug.Log(score);

                // If at certain point, characters are not equal, then clear all characters starting from FIRST wrong character
                field.text = field.text.Substring(0, ii);

                

                //kullanıcı yanlış harf girdiğinde beep sesi çalacak
                ses.PlayOneShot(yanlisSesdit[0], 29);

                return false;
            }
        }
        return true;
    }

    void Update()
    {
        totalTime += Time.deltaTime;
        UpdateLevelTimer(totalTime);


        HarfTest();
        kullaniciGirisi.text = harfler[secilenSayi];
        if (sesCaldi == true)
        {

            StartCoroutine(seslendirme(kullaniciGirisi.text));

        }

        time1 += Time.deltaTime;

        if (harfler[secilenSayi] == field.text)
        {
            veriler = (harfler[secilenSayi] + " için yanlış sayınız: " + score + Environment.NewLine + "Süre: " + totalTime);
            System.IO.File.WriteAllText(@"C:/Users/Mehtap/Desktop/Panna Cotta/Test Sonuçları/" + harfler[secilenSayi] + ".txt", veriler);
        }

            //Fonksiyonu çağır 
            if (harfler[secilenSayi].Length == field.text.Length)
            {
            if (addTime == true)
            {
                time2 = time1 + waitTime;
                addTime = false;
            }

            //fonksiyonu test et eğer doğruysa if in içindekileri yap
            if (HarfTest())
            {
                //cursor aktivasyonu kapatma
                field.DeactivateInputField();

                if (time1 > time2)
                {
                    sesCaldi = true;
                    Debug.Log(harfler[secilenSayi] + " Dogrudur");

                    totalTime = Time.deltaTime;
                    score = 0;
                    scoreText.text = score.ToString();

                    //if (timerfinish)
                    //return;
                    field.text = "";
                    //doğruysa secilen sayıyı bir artır ki yeni harf girişi istesin
                    secilenSayi = secilenSayi + 1;
                    //cursor tekrar aktive ediliyor
                    field.ActivateInputField();
                    //seçilen sayıyı listenin elemanlarından fazla arttırma ki hata vermesin    
                    if (secilenSayi > harfler.Count - 1)
                    {
                        StartCoroutine(SahneDegistirici());
                    }
                    addTime = true;

                }
            }
            else
            {
                sesCaldi = false;
                Debug.Log(harfler[secilenSayi] + " yanlış");

                field.text = "";
                secilenSayi = secilenSayi + 0;
                //seçilen sayıyı listenin elemanlarından fazla arttırma ki hata vermesin    
                if (secilenSayi > harfler.Count - 1)
                {
                    secilenSayi = harfler.Count - 1;
                }
                addTime = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sayac2 = sayac2 + 1;
            if (sayac2 == 3)
            {
                Application.Quit();
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            sayac = sayac + 1;
            if (sayac == 3)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    public void timerfinished() {
        timerfinish = true;
    }



    public void UpdateLevelTimer(float totalSeconds)
    {
        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);

        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }

        timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }


    IEnumerator bekleme(float bekleme = 1.5f)
    {
        yield return new WaitForSeconds(bekleme);
    }

    private void Stop()
    {
        throw new NotImplementedException();
    }

    private IEnumerator harftest(int secilenSayi)
    {
        throw new NotImplementedException();

    }

    IEnumerator SahneDegistirici()
    {
        yield return new
            WaitForSeconds(0.0f);
        SceneManager.LoadScene(nextSceneId);
    }
}


   

