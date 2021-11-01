using System;
using UnityEngine;
using UnityEngine.UI;


public class skor : MonoBehaviour
{

    // Use this for initialization
    public Text deneme;
    public int sayi;
    public static int skor_rakam;

    public void Start()
    {
       // GameObjec
    }


    public void Update()
    {
        Debug.Log(skor_rakam);
     
            deneme.text =sayi.ToString();
        }

    
}

