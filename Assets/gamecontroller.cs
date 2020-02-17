using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour
{
    
    public class NewBehaviourScript : MonoBehaviour
    {
        int time;
        public bool sesKontrol1 = true;

        //Harf listesi oluştur
        List<string> harfler = new List<string>();
        List<string> harfler2 = new List<string>();
        // Use this for initialization
        public InputField inputField;
        public Text inputLabel;
        //fonksiyonu çağıracagın sayıyı oluştur
        public int secilenSayi = 0;

        public bool isFinished;
        void Start()
        {
            //cursor
            inputField.ActivateInputField();

            //Moduldeki harfleri ekle
            harfler.Add("a");
            harfler.Add("l");
            harfler.Add("f");
            harfler.Add("j");
            harfler.Add("s");
            harfler.Add("k");
            harfler.Add("d");
            harfler.Add("f");
            harfler.Add("j");
            harfler.Add("d");
            harfler.Add("l");
            harfler.Add("s");
            harfler.Add("k");
            harfler.Add("");

             
        }
        //Harfi test eden fonksiyon
        public bool HarfTest()
        {
            for (int ii = 0; ii <= inputField.text.Length - 1; ii++)
            {
                if (inputField.text[ii] != inputLabel.text[ii])
                {
                    // If at certain point, characters are not equal, then clear all characters starting from FIRST wrong character
                    inputField.text = inputField.text.Substring(0, ii);
                    break;
                }
            }
            return false;
        }


        // Update is called once per frame
        void Update()
        {
            HarfTest();
        }
    }
}
          
      
    


