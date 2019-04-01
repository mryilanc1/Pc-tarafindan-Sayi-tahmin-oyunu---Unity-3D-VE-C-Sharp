using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sahneyonetici : MonoBehaviour
{
   
    public void sonrakisahne()
    {   
        int mevcutsahneindexi = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(mevcutsahneindexi + 1);
        Debug.Log(PlayerPrefs.GetInt("tur"));

    }

    public void oyunsahne()
    {

        SceneManager.LoadScene(1);


    }


   
}
