using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OyunMekanik : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] int tahmin;
    [SerializeField] TextMeshProUGUI tahminmetin;
    public int tur;
  


    void Start()
    {
        OyunBaslagic();
        tahminmetin.text = tahmin.ToString();
        tur = PlayerPrefs.GetInt("tur");
    }

   

    public void OyunBaslagic()
    {
        max++;
        sonrakitahmin();


    }

    public void artir()
    {
        min = tahmin;
        sonrakitahmin();
        PlayerPrefs.SetInt("tur", tur); /// Tur set etmek için yükseltmek için ve değişmek için kullanıyoruz...

    }

    public void azalt ()
    {
        max = tahmin;
        sonrakitahmin();
        PlayerPrefs.SetInt("tur", tur);

    }

    public void sonrakitahmin()
    {
        tur++;
        // tahmin = (max + min) / 2;  ( Algoritma değişikliiği )

        tahmin = Random.Range(min, max);

        tahminmetin.text = tahmin.ToString();

    }

}
