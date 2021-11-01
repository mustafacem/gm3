using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogru_cevap : MonoBehaviour
{
    public bool vuru=true;
    int kalas;
    // public skor sayı { get; private set; }
    skor skor1;
    public static int skor_rakam;
    void Start()
    {
        //    skor1 =// GetComponent<skor>();
       // skor1 = new skor();
        Debug.Log("dogru cevap start çalıştı");
    }


    
    // Update is called once per frame
    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("a") )
        {
            if (vuru ==true) {
                Debug.Log("kaka");
                vuru = false;
                skor_rakam = skor_rakam + 1;
                Debug.Log(skor_rakam);
            }
            //Destroy(col.gameObject);
        }
    }
}
