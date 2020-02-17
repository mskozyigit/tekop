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

public class mod6_reader : MonoBehaviour
{
    private string m_CurUser;

    public static string dataPath;
    string m_Path1;
    object tarih2;
    object tarih;
    string username;

    int sayac1 = 0;
    int sayac3 = 0;

    public int score1;
    public string name1;
    public float timePlayed;
    int sayac = 0;
    int sayac2 = 0;

    public static float fixedDeltaTime;
    public AudioSource ses;
    public AudioClip[] sesler;
    public AudioClip[] yanlisSesdit;
    public List<AudioClip> kullanicibildiriciSes = new List<AudioClip>();
    public List<AudioClip> kelimeSeslendirmesi = new List<AudioClip>();
    public List<AudioClip> harfler2 = new List<AudioClip>();


    public playonh ss;

    private float time1 = 0.0f;
    private float time2 = 0.0f;
    private float waitTime = 1.9f;
    private bool addTime = true;
    bool sesCaldi = true;
    bool sesCaldi2 = true;

    int score = 0;
    public Text scoreText;
    public Text timerText;
    public Text countupText;
    float totalTime = 0f;

    public Text timer;
    private bool timerfinish = false;

    private string veriler;

    ArrayList veriler1 = new ArrayList();

    //Harf listesi oluştur
    List<string> harfler = new List<string>();
    // Use this for initialization
    public InputField field;
    public Text kullaniciBildirici;
    public int nextSceneId;
    //public String textToRead;

    //fonksiyonu çağıracagın sayıyı oluştur
    public int secilenSayi = 0;
    List<string> kullaniciSesHarfleri = new List<string>();
    List<string> yanlisSes = new List<string>();
    List<string> kullaniciKelimeSesleri = new List<string>();
    public bool isFinished;

    public static void Main()
    {
        Console.WriteLine();

        //  <-- Keep this information secure! -->
        Console.WriteLine("UserName: {0}", Environment.UserName);
    }

    void Start()
    {
        //cursor
        //field.ActivateInputField();
        yanlisSes.Add("beep");
        ss = GameObject.Find("kullanicibildirici").GetComponent<playonh>();

        kullaniciSesHarfleri.Add("z");
        kullaniciSesHarfleri.Add("ç");
        kullaniciSesHarfleri.Add("g");
        kullaniciSesHarfleri.Add("ş");
        kullaniciSesHarfleri.Add("c");
        kullaniciSesHarfleri.Add("p");
        kullaniciSesHarfleri.Add("a");
        kullaniciSesHarfleri.Add("m");
        kullaniciSesHarfleri.Add("n");
        kullaniciSesHarfleri.Add("r");
        kullaniciSesHarfleri.Add("l");
        kullaniciSesHarfleri.Add("y");
        kullaniciSesHarfleri.Add("k");
        kullaniciSesHarfleri.Add("e");
        kullaniciSesHarfleri.Add("i");
        kullaniciSesHarfleri.Add("t");


        kullaniciKelimeSesleri.Add("gişe");
        kullaniciKelimeSesleri.Add("zaman");
        kullaniciKelimeSesleri.Add("çiçek");
        kullaniciKelimeSesleri.Add("reçel");
        kullaniciKelimeSesleri.Add("çilek");
        kullaniciKelimeSesleri.Add("şimşek");
        kullaniciKelimeSesleri.Add("zeytin");
        kullaniciKelimeSesleri.Add("pirinç");

        //Moduldeki kelime sesleri isimleri ekle
        harfler.Add("gişe");
        harfler.Add("zaman");
        harfler.Add("çiçek");
        harfler.Add("reçel");
        harfler.Add("çilek");
        harfler.Add("şimşek");
        harfler.Add("zeytin");
        harfler.Add("pirinç");

        ses = GetComponent<AudioSource>();
        PlayerPrefs.SetInt("Score", 0);
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();

        GeneralController6.SaveFile();
        GeneralController6.LoadFile();


        tarih = DateTime.Now.ToLongTimeString() + DateTime.Now.ToLongDateString();
    }

    IEnumerator seslendirme(string text)
    {
        for (int it = 0; it < text.Length; it++)
        {
            string harf = text[it].ToString().ToLower();
            int index = kullaniciSesHarfleri.IndexOf(harf);
            ses.clip = kullanicibildiriciSes[index];
            ses.PlayOneShot(kullanicibildiriciSes[index], 4);

            sesCaldi = false;
            yield return new WaitForSeconds(ses.clip.length + 0.3f);
        }
        //cursor
        field.ActivateInputField();
    
}

    IEnumerator kelimeSeslendirilmesi(string text)
    {
        string kelime = field.text;
        int indexs = kullaniciKelimeSesleri.IndexOf(kelime);
        ses.clip = kelimeSeslendirmesi[indexs];
        ses.PlayOneShot(kelimeSeslendirmesi[indexs], 5);

        sesCaldi2 = false;
        yield return new WaitForSeconds(ses.clip.length);
    }

    IEnumerator sesOkut(string text)
    {
        int indexs = kullaniciKelimeSesleri.IndexOf(text);
        ses.clip = kelimeSeslendirmesi[indexs];
        ses.PlayOneShot(kelimeSeslendirmesi[indexs], 5);

        yield return new WaitForSeconds(ses.clip.length);
    }

    //Harfi test eden fonksiyon
    public bool HarfTest()
    {
        try
        {
            var mxSize = Math.Min(field.text.Length, kullaniciBildirici.text.Length) - 1;
            if (mxSize >= 0)
            {
                var ii = mxSize;

                for (int iii = 0; iii <= field.text.Length - 1; iii++)
                {
                    if (field.text[ii] != kullaniciBildirici.text[ii])
                    {
                        // If at certain point, characters are not equal, then clear all characters starting from FIRST wrong character
                        field.text = field.text.Substring(0, ii);

                        //kullanıcı yanlış harf girdiğinde beep sesi çalacak
                        ses.PlayOneShot(yanlisSesdit[0], 3);

                        score = score + 1;
                        scoreText.text = score.ToString();
                        print("Test");
                        ss.playWord = false;



                        return false;
                    }
                    else
                    {
                        ss.playWord = true;
                        ss.playSound();
                    }
                }

            }
        }
        catch (Exception err) { return false; }
        return true;
    }

    void Update()
    {
        totalTime += Time.deltaTime;
        UpdateLevelTimer(totalTime);

        HarfTest();
        kullaniciBildirici.text = harfler[secilenSayi];
        if (sesCaldi == true)
        {
            StartCoroutine(seslendirme(kullaniciBildirici.text));
        }

        time1 += Time.deltaTime;

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
                    veriler = (" ' " + harfler[secilenSayi] + " ' " + " için yanlış sayınız: " + score + " , " + "Süreniz: " + totalTime);
                    GeneralController6.RecordUserScore(veriler, field, kullaniciBildirici);

                    totalTime = Time.deltaTime;
                    score = 0;
                    scoreText.text = score.ToString();
                    StartCoroutine(kelimeSeslendirilmesi(kullaniciBildirici.text));
                    for (long iii = 0; iii < 1000000009; iii++)
                    {

                    }
                    field.text = "";
                    //doğruysa secilen sayıyı bir artır ki yeni harf girişi istesin
                    secilenSayi = secilenSayi + 1;
                    //cursor tekrar aktive ediliyor
                    //field.ActivateInputField();
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
    public void timerfinished()
    {
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
            WaitForSeconds(0f);
        SceneManager.LoadScene(nextSceneId);
    }
}
