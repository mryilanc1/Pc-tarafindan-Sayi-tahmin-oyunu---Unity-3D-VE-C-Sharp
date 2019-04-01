using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Turyazim : MonoBehaviour
{
    public int tur;
    [SerializeField] TextMeshProUGUI tursayac;
    [SerializeField] TextMeshProUGUI Kazanma;

    void Start()
    {
        tur = PlayerPrefs.GetInt("tur");
        tursayac.text = tur.ToString();
        if(tur <= 9)
        { Kazanma.text = ("Pc Kazandi.."); }
        else if (tur >=10  )
        { Kazanma.text = ("Siz Kazandiniz.."); }
        PlayerPrefs.SetInt("tur", 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
