using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelkilitle : MonoBehaviour
{
    public int level_idem, ek;
    public Button[] levellerimB;

    // Use this for initialization
    void Start()

    {            //levellerde ilerleme kayıdını siler en baştan başlar
        //PlayerPrefs.DeleteAll();

        //Butonları tıklanamaz hale getiriyor
        for (int i = 1; i <= levellerimB.Length - 1; i++)
        {
            levellerimB[i].interactable = false;
        }


    }

    // Update is called once per frame
    void Update()
    {
        //hangi seviyedeysen o butonu aktif hale getiriyor
        level_idem = PlayerPrefs.GetInt("levelid");
        ek = PlayerPrefs.GetInt("ek");
        if (level_idem > 0)
        {
            levellerimB[level_idem].interactable = true;
        }
        //ilerlediğin tüm seviyeleri aktif gösteriyor
        for (int i = 0; i <= level_idem; i++)
        {
            levellerimB[i].interactable = true;
        }
    }
    //hata kısmı
    public void ek_sistem(int deger)
    {
        ek = deger;
        if (ek < level_idem)
        {
            PlayerPrefs.SetInt("levelid", level_idem - 1);
        }
    }


}