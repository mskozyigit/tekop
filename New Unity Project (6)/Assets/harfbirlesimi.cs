using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class harfbirlesimi : MonoBehaviour
{
    //Harf listesi oluştur
    List<string> harfler = new List<string>();
    // Use this for initialization
    public InputField field;
    public Text kullaniciGirisi;
    //fonksiyonu çağıracagın sayıyı oluştur
    public int secilenSayi = 0;

    public bool isFinished;
    void Start()
    {
        //Moduldeki harfleri ekle
        harfler.Add("f");
        harfler.Add("j");
        harfler.Add("a");
        harfler.Add("s");
        harfler.Add("d");
        harfler.Add("k");
        harfler.Add("l");
        harfler.Add("ş");
            }
    //Harfi test eden fonksiyon
    public bool HarfTest(int sayi)
    {
        //harf girilen harfe eşit mi?
        if (field.text == harfler[sayi])
        {
            Debug.Log("Dogru");
            //eşitse doğru döndür
            return true;
        }
        //eşit değilse yazılan harfi sil
        else
        {
            field.text = "";
        }
        //eşit değilse yanlış döndür
        return false;

    }


    // Update is called once per frame
    void Update()
    {
        kullaniciGirisi.text = harfler[secilenSayi] + harfler[secilenSayi] + harfler[secilenSayi] + " harfini giriniz.";
        //Fonksiyonu çağır 
        HarfTest(secilenSayi);
        //fonksiyonu test et eğer doğruysa if in içindekileri yap
        if (HarfTest(secilenSayi))
        {
            Debug.Log(harfler[secilenSayi] + " Dogrudur");
            //ses.PlayOneShot(sesler[secilenSayi], 28);
            //doğruysa secilen sayıyı bir artır ki yeni harf girişi istesin
            secilenSayi = secilenSayi + 1;
            //seçilen sayıyı listenin elemanlarından fazla arttırma ki hata vermesin    
            if (secilenSayi > harfler.Count - 1)
            {
                secilenSayi = harfler.Count - 1;
            }
        }


    }

}


   

